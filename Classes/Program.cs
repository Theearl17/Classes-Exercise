using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("object1");
           Car myCar = new Car();
           myCar.Year = 2015;
           myCar.Model = "Mustang";
           myCar.Make = "Ford";
            myCar.HonkCar();

            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");


            Console.WriteLine("object2");
            Car myCar2 = new Car();
            myCar2.Year = 1990;
            myCar2.Make = "ford";
            myCar2.Model = "focus";

            myCar2.HonkCar();
            Console.WriteLine($"{myCar2.Make} {myCar2.Model} {myCar2.Year}");
        }

    
        
    
    
    }

}
