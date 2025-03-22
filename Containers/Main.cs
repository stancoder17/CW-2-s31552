namespace Containers;

public class Program
{
    public static void Main(string[] args)
    {
        LContainer l = new LContainer(150, 11.2, 600, 532, 538);
        LContainer l2 = new LContainer(150, 11.2, 600, 532, 538);
        Console.WriteLine(l.SerialNumber);
        Console.WriteLine(l2.SerialNumber);
        GContainer g = new GContainer(150, 11.2, 600, 532, 538);
        GContainer g2 = new GContainer(150, 11.2, 600, 532, 538);
        Console.WriteLine(g.SerialNumber);
        Console.WriteLine(g2.SerialNumber);
        CContainer c = new CContainer(150, 11.2, 600, 532, 538);
        CContainer c2 = new CContainer(150, 11.2, 600, 532, 538);
        Console.WriteLine(c.SerialNumber);
        Console.WriteLine(c2.SerialNumber);
    }
}