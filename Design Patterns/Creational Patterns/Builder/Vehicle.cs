namespace Design_Patterns.Creational_Patterns.Builder;

public class Vehicle
{
    private readonly Dictionary<string, string> _parts = new();

    // Indexer
    public string this[string key]
    {
        get => _parts[key];
        set => _parts[key] = value;
    }

    public void Show()
    {
        foreach (var part in _parts)
        {
            Console.Write($"{part.Key}: {part.Value} \n");
        }
    }
}