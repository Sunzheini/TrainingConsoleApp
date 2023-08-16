using System;


// comment
namespace TrainingConsoleApp 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // // variables
            // const int x = 7;
            // double y = 5.5;
            // bool z = true;
            // char symbol = 'a';
            // string str = "Hello World!";
            //
            // // Math class
            // Console.WriteLine(Math.Abs(-x));        // 7
            // Console.WriteLine(Math.Pow(2, 3));      // 2 ** 3 == 8
            // Console.WriteLine(Math.Ceiling(y));     // 6
            // Console.WriteLine(Math.Max(x, Convert.ToInt32(y)));       // max(x, y) == 7
            //
            // // if statement
            // if (z)
            // {
            //     Console.WriteLine("x = " + x);
            // } 
            // else if (!z)
            // {
            //     Console.WriteLine("x = 1");
            // }
            // else
            // {
            //     Console.WriteLine("x != 7");
            // }
            //
            // // casting
            // int a = Convert.ToInt32(y);             // double to int, truncates decimals
            // Console.WriteLine(a.GetType());         // System.Int32
            // string b = Convert.ToString(x);         // int to string
            // Console.WriteLine(b.GetType());         // System.String
            //
            // // press key
            // // Console.WriteLine("Press any key to exit.");
            // // Console.ReadKey(true);
            //
            // // user input
            // string name = "";
            // Console.WriteLine("Enter your name: ");
            // name = Console.ReadLine();
            // Console.WriteLine("Hello " + name);
            //
            // // random
            // Random rand = new Random();
            // int randNum = rand.Next(1, 11);         // random number from 1 to 10
            //
            // // string methods
            // Console.WriteLine(str.Length);          // 12, Length is a property!
            // Console.WriteLine(str.ToUpper());       // HELLO WORLD!
            // Console.WriteLine(str.ToLower());       // hello world!
            //
            // Console.WriteLine(str.Contains("Hello"));      // true
            // Console.WriteLine(str.IndexOf("World"));       // starting index is 6
            // Console.WriteLine(str.Substring(6, 5));        // World
            // Console.WriteLine(str.Substring(6));           // World!
            // Console.WriteLine(str.Remove(5));              // Hello
            // Console.WriteLine(str.Replace("World", "C#")); // Hello C#!
            // Console.WriteLine(str.Insert(5, "C#"));        // Hello C# World!
            //
            // // switch statement
            // string day = Console.ReadLine();
            // switch (day)
            // {
            //     case "m":
            //         Console.WriteLine("Monday");
            //         break;
            //     case "t":
            //         Console.WriteLine("Tuesday");
            //         break;
            //     default:
            //         Console.WriteLine("Invalid day");
            //         break;
            // }
            //
            // // logical operators
            // // &&, ||, !
            //
            // // while loop
            // int k = 0;
            // while (k < 5)
            // {
            //     Console.WriteLine(k);
            //     k++;
            // }
            //
            // // for loop
            // for (int j = 0; j < 5; j++)     // j is only visible inside the loop
            // {
            //     Console.WriteLine(j);
            // }
            //
            // // arrays
            // string[] cars = { "BMW", "Audi", "Mercedes" };   // arrays have fixed size
            // Console.WriteLine(cars);            // System.String[]: the datatype of the array
            // cars[2] = "Porsche";
            //
            // string[] cars2 = new string[5];     // empty array of size 5
            //
            // for (int i = 0; i < cars.Length; i++)
            // {
            //     Console.WriteLine(cars[i]);
            // }
            //
            // // foreach loop: only forward iteration for arrays
            // foreach (string car in cars)
            // {
            //     Console.WriteLine(car);
            // }
            //
            // // methods
            // string myName = "Daniel";
            // Console.WriteLine(singHappyBirthday(myName));
            // Console.WriteLine(singHappyBirthday(myName));
            //
            // // overloading: same method name, different parameters
            // // name + parameters = signature (which must be unique)!
            // Console.WriteLine(singHappyBirthday(myName, 2));
            //
            // // params keyword
            // Console.WriteLine(CheckOut(1.5, 2.5, 3.5));
            //
            // // try-catch
            // try
            // {
            //     Console.WriteLine("Enter a number: ");
            //     int num1 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Enter another number: ");
            //     int num2 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine(num1 / num2);
            // }
            // catch (DivideByZeroException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // catch (FormatException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // catch (Exception e)     // catch all, not a good practice
            // {
            //     Console.WriteLine(e.Message);
            // }
            // finally
            // {
            //     Console.WriteLine("Finally block");
            // }
            //
            // // conditional operator: (condition) ? do if true : do if false
            // int num = 7;
            // string result = (num % 2 == 0) ? "even" : "odd";
            // Console.WriteLine(result);
            //
            // // string interpolation: $ before the string
            // string firstName = "Daniel";
            // string lastName = "Zorov";
            // Console.WriteLine($"My name is {firstName} {lastName}.");
            //
            // // multi-dimensional arrays
            // int[,] matrix = new int[2, 3];                   // 2 rows, 3 columns
            // int[,] matrix2 = { { 1, 2, 3 }, { 4, 5, 6 } };   // 2 rows, 3 columns
            // for(int row = 0; row < matrix2.GetLength(0); row++)   
            // {       // GetLength() is a pre-defined method of the Array class
            //     for(int col = 0; col < matrix2.GetLength(1); col++)
            //     {   // on one-dimensional arrays Length will return the same value as GetLength(0)
            //         Console.WriteLine(matrix2[row, col]);
            //     }
            // }
            
            // classes
            // on classes static allows usage without instantiation
            // on field and methods static == cls in Python
            
            // public on fields and methods allows usage outside
            // All members in a Python class are public by default
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();
            
            // objects
            Human daniel = new Human("daniel", 21);
            daniel.Eat();
            daniel.Sleep();
            Car car1 = new Car("Ford", "Mustang", 2021, "red");
            car1.Drive();
            Console.WriteLine(Car.numCars);     // 1
            Car car2 = new Car("Porsche", "911", 2021, "blue"); 
            car2.Drive();
            Console.WriteLine(Car.numCars);     // 2
            
            // overloaded constructors: like overloaded methods
            
            // inheritance: CarFromVehicle : Vehicle
            CarFromVehicle car3 = new CarFromVehicle();
            Console.WriteLine(car3.speed);     // 0
            
            // abstract classes: abstract class Vehicle
            
            // arrays of objects
            Car[] garage = new Car[2];    // empty array of size 3
            garage[0] = car1;
            garage[1] = car2;
            Console.WriteLine(garage[0].make);     // Ford
            
            // override methods: use 'override' in method that overrides
            // virtual in methods == @abstractmethod in Python, can have contents in method
            // also abstract in method and class == @abstractmethod in Python, no contents in method
            Dog dog1 = new Dog();
            dog1.Speak();       // I am a dog.
            Cat cat1 = new Cat();
            cat1.Speak();       // I am an animal.
            
            // ToString() method == __str__ in Python
            // use with override
            Console.WriteLine(dog1.ToString());     // TrainingConsoleApp.Dog
            
            // polymorphism: use 'virtual' in method that is overridden
            CarFromVehicle car11 = new CarFromVehicle();
            TruckFromVehicle truck11 = new TruckFromVehicle();
            Vehicle[] vehicles = { car11, truck11 };
            Console.WriteLine(vehicles[1].speed);       // 5
            
            // interfaces == ABC, abstractmethod in Python
            Rabbit rabbit1 = new Rabbit();
            rabbit1.Flee();     // The rabbit is fleeing
            Fish fish1 = new Fish();
            fish1.Flee();       // The fish is fleeing
            fish1.Hunt();       // The fish is hunting
            
            // lists: can be resized unlike arrays
            
        }
        
        // // methods
        // static string singHappyBirthday(string name)    // specify the return type, void if no return
        // {
        //     return "Happy Birthday to you!" + name;
        // }
        //
        // // overloading
        // static string singHappyBirthday(string name, int numTimes)
        // {
        //     string song = "";
        //     for (int i = 0; i < numTimes; i++)
        //     {
        //         song += "Happy Birthday to you!" + name + "\n";
        //     }
        //     return song;
        // }
        //
        // // params keyword: parameter type must be a single dimensional array
        // static double CheckOut(params double[] prices)
        // {
        //     double total = 0;
        //     foreach (double price in prices)
        //     {
        //         total += price;
        //     }
        //     return total;
        // }
    }
}
