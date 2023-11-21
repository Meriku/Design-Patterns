namespace Design_Patterns.Creational_Patterns.Abstract_Factory;

public abstract class Product
{
    protected int Price;

    public void ShowPrice()
    {
        var productName = GetType().Name;
        Console.Write($"Product: {productName}; Price: {Price} \n");
    }
}

public abstract class Apple: Product
{
}

public abstract class Orange: Product
{
}

public abstract class Banana: Product
{
}

public class TurkishApple : Apple
{
    public TurkishApple()
    {
        Price = 1;
    }
}

public class TurkishOrange : Orange
{
    public TurkishOrange()
    {
        Price = 3;
    }
}

public class TurkishBanana : Banana
{
    public TurkishBanana()
    {
        Price = 5;
    }
}

public class EgyptApple : Apple
{
    public EgyptApple()
    {
        Price = 2;
    }
}

public class EgyptOrange : Orange
{
    public EgyptOrange()
    {
        Price = 4;
    }
}

public class EgyptBanana : Banana
{
    public EgyptBanana()
    {
        Price = 6;
    }
}
