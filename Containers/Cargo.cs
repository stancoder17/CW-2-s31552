namespace Containers;

public abstract class Cargo
{
    public string Name { get; }

    protected Cargo(string name)
    {
        Name = name;
    }
}
