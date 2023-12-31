using Design_Patterns.Creational_Patterns.Abstract_Factory;

namespace Main;


/// <summary>
/// The Abstract Factory design pattern provides an interface for creating families of related or dependent objects
/// without specifying their concrete classes.
/// </summary>
public static class AbstractFactoryExample
{
    public static void ShowExample()
    {
        Console.WriteLine("\nStart: Abstract Factory Example\n");
        
        AbstractFactory turkishFactory = new TurkishProductFactory();
        Product[] turkishProducts = { turkishFactory.CreateApple(), turkishFactory.CreateOrange(), turkishFactory.CreateBanana() };

        // Abstract factory #2
        AbstractFactory egyptFactory = new EgyptProductFactory();
        Product[] egyptProducts = { egyptFactory.CreateApple(), egyptFactory.CreateOrange(), egyptFactory.CreateBanana() };

        foreach (var turkishProduct in turkishProducts)
        {
            turkishProduct.ShowPrice();
        }

        foreach (var egyptProduct in egyptProducts)
        {
            egyptProduct.ShowPrice();
        }
        
        Console.WriteLine("\nEnd: Abstract Factory Example");
    }
}