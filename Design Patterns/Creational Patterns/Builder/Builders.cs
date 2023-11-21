namespace Design_Patterns.Creational_Patterns.Builder;

public class MotorCycleBuilder : VehicleBuilder
{
    public override void BuildFrame(string color)
    {
        vehicle["frame"] = "MotorCycle Frame";
        vehicle["color"] = color;
    }
    public override void BuildEngine()
    {
        vehicle["engine"] = "500 cc";
    }
    public override void BuildWheels()
    {
        vehicle["wheels"] = "2";
    }
    public override void BuildDoors()
    {
        vehicle["doors"] = "0";
    }
}

public class CarBuilder : VehicleBuilder
{
    public override void BuildFrame(string color)
    {
        vehicle["frame"] = "Car Frame";
        vehicle["color"] = color;
    }
    public override void BuildEngine()
    {
        vehicle["engine"] = "2500";
    }
    public override void BuildWheels()
    {
        vehicle["wheels"] = "4";
    }
    public override void BuildDoors()
    {
        vehicle["doors"] = "4";
    }
}

public class ScooterBuilder : VehicleBuilder
{
    public override void BuildFrame(string color)
    {
        vehicle["frame"] = "Scooter Frame";
        vehicle["color"] = color;
    }
    public override void BuildEngine()
    {
        vehicle["engine"] = "50";
    }
    public override void BuildWheels()
    {
        vehicle["wheels"] = "2";
    }
    public override void BuildDoors()
    {
        vehicle["doors"] = "0";
    }
}