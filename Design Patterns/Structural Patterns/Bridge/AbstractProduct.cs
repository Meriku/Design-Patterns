namespace Design_Patterns.Structural_Patterns.Bridge;

public abstract class Book
{
    protected IBookContent bookContent;

    protected Book(IBookContent content)
    {
        bookContent = content;
    }

    public abstract void Produce();
}

public interface IBookContent
{
    void CreateContent();
}