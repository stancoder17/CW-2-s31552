namespace Containers;

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message) { }
}