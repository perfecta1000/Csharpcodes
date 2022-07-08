// See https://aka.ms/new-console-template for more information
while (true)
{ 
Console.WriteLine(" calculator");
Console.WriteLine("The operators are +,-,*,/,%,~ ");
Console.WriteLine("Enter your first number");
string num1 = Console.ReadLine();
Console.WriteLine("Enter your operator");
string op = Console.ReadLine();
Console.WriteLine("Enter your second number");
string num2 = Console.ReadLine();


if (op == "+")
{
   
    Console.WriteLine($"the result is {int.Parse(num1) + int.Parse(num2)}");
}
else if (op == "-")
{
    Console.WriteLine($"the result is {int.Parse(num1) - int.Parse(num2)}");
}
else if (op == "*")
{
    Console.WriteLine($"the result is {int.Parse(num1) * int.Parse(num2)}");
}
else if (op == "/")
{
    Console.WriteLine($"the result is {int.Parse(num1) / int.Parse(num2)}");
}
else if (op == "%")
{
    Console.WriteLine($"the result is {int.Parse(num1) % int.Parse(num2)}");
}
else if (op == "~")
{
    Console.WriteLine($"the result is {int.Parse(num1) + int.Parse(num2)}");
}
else
{
    Console.WriteLine("Invalid operator");
}
}
