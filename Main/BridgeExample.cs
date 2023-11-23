using Design_Patterns.Structural_Patterns.Bridge;

namespace Main;

public static class BridgeExample
{
    public static void ShowExample()
    {
        Console.WriteLine("\nStart: Bridge Example\n");
        
        
        // Creating content for English language
        IBookContent englishContent = new EnglishContent();

        // Creating different books with English content
        Book englishMathBook = new MathBook(englishContent);
        Book englishHistoryBook = new HistoryBook(englishContent);

        // Producing books with English content
        englishMathBook.Produce();
        englishHistoryBook.Produce();

        Console.WriteLine();

        // Creating content for Spanish language
        IBookContent spanishContent = new FrenchContent();

        // Creating different books with Spanish content
        Book spanishMathBook = new MathBook(spanishContent);
        Book spanishHistoryBook = new HistoryBook(spanishContent);

        // Producing books with Spanish content
        spanishMathBook.Produce();
        spanishHistoryBook.Produce();

        Console.WriteLine("\nEnd: Bridge Example");
    }
}