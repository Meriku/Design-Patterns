using Design_Patterns.Structural_Patterns.Adapter;

namespace Main;

public static class AdapterExample
{
    public static void ShowExample()
    {
        Console.WriteLine("\nStart: Adapter Example\n");
        
        // var vehicles = new Vehicle[] {new Car(), new Scooter(), new Boat()};
        // foreach (var vehicle in vehicles)
        // {
        //     vehicle.Move() - is not working
        // }
        
        var richVehicles = new RichVehicle[] {new RichCar(), new RichScooter(), new RichBoat()};

        foreach (var richVehicle in richVehicles)
        {
            richVehicle.Move();
        }
        
        Console.WriteLine("\nEnd: Adapter Example");
    }
}