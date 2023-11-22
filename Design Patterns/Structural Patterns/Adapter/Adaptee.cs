namespace Design_Patterns.Structural_Patterns.Adapter;


/// <summary>
/// Some example of outdated / legacy / external code, that should be adapted to the new code.
/// </summary>

public abstract class Vehicle
{
    
}
public class Car:Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving car.");
    }   
}
public class Scooter:Vehicle
{
    public void Move()
    {
        Console.WriteLine("Moving scooter.");
    }
}
public class Boat:Vehicle
{
    public void Sail()
    {
        Console.WriteLine("Sailing boat.");
    }
}