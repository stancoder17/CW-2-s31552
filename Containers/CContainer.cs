﻿namespace Containers;

public class CContainer : Container<CooledCargo>
{
    private static int _id = 1;

    public CContainer(double mass, double height, double netWeight, double depth, double maxLoadCapacity)
        : base(mass, height, netWeight, depth, maxLoadCapacity)
    {
    }
    
    protected override string GenerateSerialNumber()
    {
        return "KON-C-" + _id++;
    }
    
    protected override void ValidateSpecificLoadingConditions(double massToLoad)
    {
        
    }
    
    protected override void ValidateSpecificUnloadingConditions(double massToUnload)
    {
        
    }
}