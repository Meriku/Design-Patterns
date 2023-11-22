namespace Design_Patterns.Structural_Patterns.Adapter;

public abstract class RichVehicle
{
    public abstract void Move();
}

public class RichCar: RichVehicle
{
    private readonly Car _car = new();
    
    public override void Move()
    {
        _car.Drive();
    }   
}
public class RichScooter: RichVehicle
{
    private readonly Scooter _scooter = new();
    
    public override void Move()
    {
        _scooter.Move();
    }
}
public class RichBoat: RichVehicle
{
    private readonly Boat _boat = new();
    
    public override void Move()
    {
        _boat.Sail();
    }
}