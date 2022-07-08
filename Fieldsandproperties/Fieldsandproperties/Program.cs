// See https://aka.ms/new-console-template for more information

namespace Fieldsandproperties
{
    class program
    {
        static void Main(String[] args)
        { 
            Car motor = new Car();
            motor.speedProperty = 5000;
            motor.wheelProperty = 5;
            motor.colour = "green";


            Console.WriteLine(motor.speedProperty);
            Console.WriteLine(motor.wheelProperty);
            Console.WriteLine(motor.colour);
        }
    }

}