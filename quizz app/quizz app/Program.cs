// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome, kindly perform your Quizz App");
Console.WriteLine("you have 10 question below kindly answer them accordinly please!");

string[] question1 = { "(a)book", "(b)pen", "(c)papper", "(c)cloth" };
Console.WriteLine("Question 1");
Console.WriteLine("All of these are required to write exam expect?");
foreach (string question in question1)
{
    Console.WriteLine(question);
}
Console.ReadLine();
if (question1 == [3])
{
    Console.WriteLine("YOUR ANSWER IS CORRECT");
    Console.WriteLine("YOU SCORED ONE POINT");
}
else if (question1 ==[0, 1, 2])
{
    Console.WriteLine("YOUR ANSWER IS WRONG");
    Console.WriteLine("YOU DIDN'T GET A ONE POINT");
}
