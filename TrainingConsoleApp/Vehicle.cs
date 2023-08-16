namespace TrainingConsoleApp;

public class Vehicle
{
    public int speed = 0;
    
    void Go()
    {
        Console.WriteLine("This vehicle is moving");
    }
}

public class CarFromVehicle : Vehicle
{
}

public class TruckFromVehicle : Vehicle
{
}
