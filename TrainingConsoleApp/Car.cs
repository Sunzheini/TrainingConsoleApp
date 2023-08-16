namespace TrainingConsoleApp;

public class Car
{
    public string make;
    string model;
    int year;
    string color;
    
    public static int numCars = 0;
    
    public Car(string make, string model, int year, string color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
        
        numCars++;
    }
    
    public void Drive()
    {
        Console.WriteLine("Driving: " 
                          + make + " " 
                          + model + " " 
                          + year + " " 
                          + color);
    }
}
