// See https://aka.ms/new-console-template for more information
Console.WriteLine("caculator");
string num1=Console.ReadLine();

Console.WriteLine("plus");
string num2=Console.ReadLine();
Console.WriteLine(int.Parse(num1) + int.Parse(num2));

Console.WriteLine("multiply");
string num3= Console.ReadLine();
int total= int.Parse(num1) + int.Parse(num2);
Console.WriteLine(total * int.Parse(num3));

Console.WriteLine("subtract");
string num4 = Console.ReadLine();
int total1 = total * int.Parse(num3);
Console.WriteLine(total1- int.Parse(num4));

Console.WriteLine("divide");
string num5 = Console.ReadLine();
int total2 = total1 - int.Parse(num4);
Console.WriteLine(total2 / int.Parse(num5));