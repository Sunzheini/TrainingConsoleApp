namespace TrainingConsoleApp;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("I am an animal.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("I am a dog.");
    }
    
    public override string ToString()
    {
        return "I am a dog.";
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("I am a cat.");
    }
}
