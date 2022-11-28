namespace CSharp9.Models;
public record class Record10
{
    public string Name { get; init; }
    public int Roll { get; init; }

    public sealed override string ToString()
    {
        return $"Name: {Name}, Roll: {Roll}";
    }
}

public record Child : Record10
{
    public string ChildName { get; init; }
}
