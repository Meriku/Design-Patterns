namespace Design_Patterns.Creational_Patterns.Abstract_Factory;

public class TurkishProductFactory : AbstractFactory
{
    public override Apple CreateApple()
    {
        return new TurkishApple();
    }
    public override Orange CreateOrange()
    {
        return new TurkishOrange();
    }
    public override Banana CreateBanana()
    {
        return new TurkishBanana();
    }
}

public class EgyptProductFactory : AbstractFactory
{
    public override Apple CreateApple()
    {
        return new EgyptApple();
    }
    public override Orange CreateOrange()
    {
        return new EgyptOrange();
    }
    public override Banana CreateBanana()
    {
        return new EgyptBanana();
    }
}