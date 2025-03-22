namespace Containers;

public class GContainer : Container
{
    private static int _id = 1;

    public GContainer(double mass, double height, double netWeight, double depth, double maxLoadCapacity)
        : base(mass, height, netWeight, depth, maxLoadCapacity)
    {
    }
    
    protected override string GenerateSerialNumber()
    {
        return "KON-G-" + _id++;
    }
    
    protected override void ValidateSpecificLoadingConditions(double massToLoad)
    {
        
    }
    
    protected override void ValidateSpecificUnloadingConditions(double massToUnload)
    {
        
    }
}