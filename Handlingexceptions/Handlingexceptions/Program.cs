// See https://aka.ms/new-console-template for more information


Console.WriteLine("welcome to your calculator app");
try
{
    Console.WriteLine("Enter your first number");
    string num1 = Console.ReadLine();
    Console.WriteLine("Enter your second number");
    string num2 = Console.ReadLine();

    Console.WriteLine($"your final answer is {(decimal)int.Parse(num1) / int.Parse(num2)}");
}
catch (FormatException )
{
    Console.WriteLine("Error!! Please take note only numbers are allowed.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Please!! Be informed you can't divide by 0");
}
catch (Exception  )
{ 
    Console.WriteLine("WRONG!!!");
}
finally
{
    Console.WriteLine("YOUR WELCOME");
}
