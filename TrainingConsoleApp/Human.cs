namespace TrainingConsoleApp;

class Human
{
    public string name;
    public int age;
    
    // constructor
    public Human(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Eat()
    {
        Console.WriteLine(name + age + "Eating");
    }
    
    public void Sleep()
    {
        Console.WriteLine(name + age + "Sleeping");
    }
}
