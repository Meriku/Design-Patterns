using Design_Patterns.Creational_Patterns.Builder;

namespace Main;

/// <summary>
/// The Builder design pattern separates the construction of a complex object from its representation
/// so that the same construction process can create different representations.
/// </summary>
public static class BuilderExample
{
    public static void ShowExample()
    {
        Console.WriteLine("\nStart: Builder Example\n");
        
        VehicleBuilder builder;
        builder = new ScooterBuilder();
        builder.BuildFrame("red");
        builder.BuildEngine();
        builder.BuildWheels();
        builder.BuildDoors();
        builder.Vehicle.Show();
        Console.WriteLine();
        
        builder = new CarBuilder();
        builder.BuildFrame("black");
        builder.BuildEngine();
        builder.BuildWheels();
        builder.BuildDoors();
        builder.Vehicle.Show();
        Console.WriteLine();
        
        builder = new MotorCycleBuilder();
        builder.BuildFrame("white");
        builder.BuildEngine();
        builder.BuildWheels();
        builder.BuildDoors();
        builder.Vehicle.Show();

        Console.WriteLine("\nEnd: Builder Example");
    } 
}