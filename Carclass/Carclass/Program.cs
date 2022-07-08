// See https://aka.ms/new-console-template for more information
namespace Carclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.platenumber = 123_456;
            car1.brand = "Hilux";
            car1.speed = 90;
            car1.colour = "Dark blue";
            car1.efficiency = "Best!! Works automatically.";
            Console.WriteLine(car1.platenumber);
            
            Car car2 = new Car();
            car2.platenumber = 122_444;
            car2.brand = "Benz";
            car2.speed = 100;
            car2.colour = "Black";
            car2.efficiency = "Best!! Works automatically & Super Great!!.";

            Car car3 = new Car(123_555, "Toyota", 85, "Grey", "Good! but needs improvement");
            Console.WriteLine(car3.colour);
            

        }
    }
}
