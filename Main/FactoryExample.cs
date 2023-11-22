using Design_Patterns.Creational_Patterns.Factory;

namespace Main;

public static class FactoryExample
{
    public static void ShowExample()
    {
        Console.WriteLine("\nStart: Factory Example\n");

        Document[] documents = new Document[2];
        documents[0] = new Resume();
        documents[1] = new Report();

        foreach (var document in documents)
        {
            Console.WriteLine($"{document.GetType().Name}:");
            foreach (var page in document.Pages)
            {
                Console.WriteLine($"- {page.GetType().Name}");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("End: Factory Example");
    }
}