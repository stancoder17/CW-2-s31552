// See https://aka.ms/new-console-template for more information
namespace Containers;

public abstract class Container
{
    private double _mass; // kg
    private double _height; // cm
    private double _netWeight; // kg
    private double _depth; // cm
    private double _maxLoadCapacity; // kg
    private string _serialNumber;
    
    public Container(double mass, double height, double netWeight, double depth, double maxLoadCapacity)
    {
        _mass = mass;
        _height = height;
        _netWeight = netWeight;
        _depth = depth;
        _maxLoadCapacity = maxLoadCapacity;
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
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(Height), "Wysokość musi być dodatnia");
            
            _height = value;
        }
        
    }

    public double NetWeight
    {
        get => _netWeight;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(NetWeight), "Masa własna musi być dodatnia");
            
            _netWeight = value;
        }
    }

    public double Depth
    {
        get => _depth;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(NetWeight), "Głębokość musi być dodatnia");

            _depth = value;
        }
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

    // Methods
    
    public void UnloadCargo(double massToUnload)
    {
        if (!IsUnloadingCargoOperationValid(massToUnload))
        {
            throw new InvalidOperationException("Operacja niepoprawna");
        }

        if (massToUnload > Mass)
            Mass = 0;
        else 
            Mass -= massToUnload;
    }

    public void LoadCargo(double massToLoad)
    {
        if (Mass + massToLoad > MaxLoadCapacity)
            throw new OverfillException("Zbyt duży ładunek!");

        if (!IsLoadingCargoOperationValid(massToLoad))
            throw new InvalidOperationException("Operacja niepoprawna");
        
        Mass += massToLoad;
    }

    // Abstract methods
    
    protected abstract string GenerateSerialNumber();

    protected abstract bool IsLoadingCargoOperationValid(double massToLoad);
    
    protected abstract bool IsUnloadingCargoOperationValid(double massToUnLoad);
}