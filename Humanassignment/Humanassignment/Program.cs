// See https://aka.ms/new-console-template for more information
namespace fieldsandproperty_classwork
{
    class program
    {
        static void Main(string[] args)
        { 
            human humanbeing = new human();
            humanbeing.eyeProperty = 3;
            humanbeing.legProperty = 3;
            humanbeing.teethProperty = 9;
            humanbeing.colour = "fair";

            Console.WriteLine(humanbeing.eyeProperty);
            Console.WriteLine(humanbeing.legProperty);
            Console.WriteLine(humanbeing.teethProperty);
            Console.WriteLine(humanbeing.colour);
        }
    }

}
