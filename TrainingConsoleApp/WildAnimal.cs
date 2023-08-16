namespace TrainingConsoleApp;

public class WildAnimal
{
    
}

interface IPrey
{
    void Flee();
}

interface IPredator
{
    void Hunt();
}

class Rabbit : IPrey
{
    public void Flee()
    {
        Console.WriteLine("The rabbit is fleeing");
    }
}

class Hawk : IPredator
{
    public void Hunt()
    {
        Console.WriteLine("The hawk is hunting");
    }
}

class Fish : IPrey, IPredator
{
    public void Flee()
    {
        Console.WriteLine("The fish is fleeing");
    }

    public void Hunt()
    {
        Console.WriteLine("The fish is hunting");
    }
}
