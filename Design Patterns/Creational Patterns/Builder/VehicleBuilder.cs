namespace Design_Patterns.Creational_Patterns.Builder;

public abstract class VehicleBuilder
{
    protected Vehicle vehicle;
    // Gets vehicle instance
    public Vehicle Vehicle => vehicle;

    protected VehicleBuilder()
    { vehicle = new Vehicle(); }
    
    // Abstract build methods
    public abstract void BuildFrame(string color);
    public abstract void BuildEngine();
    public abstract void BuildWheels();
    public abstract void BuildDoors();
}