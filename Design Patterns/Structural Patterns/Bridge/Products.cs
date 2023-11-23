namespace Design_Patterns.Structural_Patterns.Bridge;

public class HistoryBook : Book
{
    public HistoryBook(IBookContent content) : base(content)
    {
    }

    public override void Produce()
    {
        Console.Write("History book ");
        bookContent.CreateContent();
    }
}

public class MathBook : Book
{
    public MathBook(IBookContent content) : base(content)
    {
    }

    public override void Produce()
    {
        Console.Write("Math book ");
        bookContent.CreateContent();
    }
}

public class EnglishContent : IBookContent
{
    public void CreateContent()
    {
        Console.WriteLine("Creating content in English.");
    }
}

public class FrenchContent : IBookContent
{
    public void CreateContent()
    {
        Console.WriteLine("Creating content in French.");
    }
}