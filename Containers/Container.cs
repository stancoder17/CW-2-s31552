﻿// See https://aka.ms/new-console-template for more information
namespace Containers;

public abstract class Container<TCargo> where TCargo : Cargo
{
    private double _mass; // kg
    private readonly double _height; // cm
    private readonly double _netWeight; // kg
    private readonly double _depth; // cm
    private double _maxLoadCapacity; // kg
    private string _serialNumber;
    public TCargo Cargo { get; set; }
    
    protected Container(double mass, double height, double netWeight, double depth, double maxLoadCapacity)
    {
        Mass = mass;
        _height = height;
        _netWeight = netWeight;
        _depth = depth;
        MaxLoadCapacity = maxLoadCapacity;
        SerialNumber = GenerateSerialNumber();
    }

    
    
    
    
    // Getters and setters
    
    public double Mass
    {
        get => _mass;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Mass), "Masa nie może być ujemna");
            
            _mass = value;
        } 
    }

    public double Height
    {
        get => _height;
    }

    public double NetWeight
    {
        get => _netWeight;
    }

    public double Depth
    {
        get => _depth;
    }

    public double MaxLoadCapacity
    {
        get => _maxLoadCapacity;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(MaxLoadCapacity),
                    "Maksymalna ładowność nie może być ujemna");
            
            _maxLoadCapacity = value;
        }
    }
    
    public string SerialNumber { get => _serialNumber; set => _serialNumber = value; }
    
    
    
    
    // Methods
    
    public void UnloadCargo(double massToUnload)
    {
        if (massToUnload < 0)
            Console.WriteLine("Unloading aborted. Please provide a non-negative value");
        
        ValidateSpecificUnloadingConditions(massToUnload);
        
        if (massToUnload > Mass)
            Mass = 0;
        else 
            Mass -= massToUnload;
        

    }

    public void LoadCargo(double massToLoad)
    {
        
        if (Mass + massToLoad > MaxLoadCapacity)
            throw new OverfillException("Too large mass to load");
        
        if (Cargo == null)
            throw new NullReferenceException("Cargo is null, add cargo first");

        ValidateSpecificLoadingConditions(massToLoad);
        
        Mass += massToLoad;
    }

    
    
    
    
    // Abstract methods
    
    protected abstract string GenerateSerialNumber();

    protected abstract void ValidateSpecificLoadingConditions(double massToLoad);
    
    protected abstract void ValidateSpecificUnloadingConditions(double massToUnLoad);
}