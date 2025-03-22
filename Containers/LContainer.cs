namespace Containers;

public class LContainer : Container
{
    private static int _id = 1;

    public LContainer(double mass, double height, double netWeight, double depth, double maxLoadCapacity)
        : base(mass, height, netWeight, depth, maxLoadCapacity)
    {
    }

    protected override string GenerateSerialNumber()
    {
        return "KON-L-" + _id++;
    }

    protected override void ValidateSpecificLoadingConditions(double massToLoad)
    {
        
    }
    
    protected override void ValidateSpecificUnloadingConditions(double massToUnload)
    {
        
    }
}