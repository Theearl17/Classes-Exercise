namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           var myCar = new Car();
           myCar.Year = 2015;
           myCar.Model = "Mustang";
           myCar.Make = "Ford";

            foreach (var car in myCar);
            {
                Console.WriteLine($"{Car.Make} ${Car.Model} ${Car.Year}");
            }



        }

    
        
    
    
    }

}
