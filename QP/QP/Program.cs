// See https://aka.ms/new-console-template for more information

Console.WriteLine("WELCOME!");
Console.WriteLine("KINDLY GET STARTED WITH YOUR QUIZZ");

List<int> total = new List<int>();
Console.WriteLine("YOUR HAVE 5 QUESTIONS TO ANSWER IN THIS SECTION");

Console.WriteLine("FIRST QUESTION! ");
Console.WriteLine("1.All of these helps in writing exam except?");
Console.WriteLine("A, pen");
Console.WriteLine("B, pencil");
Console.WriteLine("C, cloth");

string question1 = Console.ReadLine();


if (question1 == "C")
{
    Console.WriteLine("CORRECT!");
    Console.WriteLine("congratulations you passed with two point");
    total.Add(2);
}

else if (question1 != "A" && question1 != "B" && question1 != "C")
{
    Console.WriteLine("iNVALID COMMAND");
    Console.WriteLine("KINDLY CHOOSE FROM THE ABOVE OPTIONS! ");
}
else
{
    Console.WriteLine("WRONG");
    Console.WriteLine("you failed and couldn't get any point");
}

Console.WriteLine("SECOND QUESTION");

Console.WriteLine("2. Before you can browse the internet you must use data?");
Console.WriteLine("A, false");
Console.WriteLine("B, true");


string question2 = Console.ReadLine();
if (question2 == "B")
{
    Console.WriteLine("CORRECT");
    Console.WriteLine("congratulations you passed with two point");
    total.Add(2);
    if (question1 != "C" && question2 != "B")
    {
        Console.WriteLine("congratulations your total is now FOUR point");
    }
    else 
    {
        Console.WriteLine("YOU GOT -2 FROM THE FIRST POINT");
    }
}

else if (question2 != "A" && question2 != "B")
{
    Console.WriteLine("iNVALID COMMAND");
    Console.WriteLine("KINDLY CHOOSE FROM THE ABOVE OPTIONS! ");
}

else
{
    Console.WriteLine("WRONG");
    Console.WriteLine("you failed and couldn't get any point");
}

Console.WriteLine("THIRD QUESTION");

Console.WriteLine("3. wihtout writing jamb and post utme you cant enter into the university");
Console.WriteLine("A, true");
Console.WriteLine("B, false");

string question3 = Console.ReadLine();
if (question3 == "A")
{
    {
        Console.WriteLine("CORRECT");
        Console.WriteLine("congratulations you passed with two point");
        total.Add(2);
        if (question1 == "C" && question2 == "B" && question3 == "A")
        {
            Console.WriteLine("congratulations  your total is now  SIX point");
        }
        else
        {
            Console.WriteLine("YOU GOT -2 FROM THE FIRST POINT");
        }
    }
}
else if (question3 != "A" && question3 != "B")
{
    Console.WriteLine("iNVALID COMMAND");
    Console.WriteLine("KINDLY CHOOSE FROM THE ABOVE OPTIONS! ");
}
else
{
    Console.WriteLine("WRONG");
    Console.WriteLine("you failed and couldn't get any point");
}

Console.WriteLine("TWO MORE QUESTIONS LEFT");


Console.WriteLine("4.living with an  infected person with HIV you may be likly to contact");
Console.WriteLine("A, true");
Console.WriteLine("B, false");
Console.WriteLine("C, Not likly to have");

string question4 = Console.ReadLine();
if (question4 == "C")
{
    {
        Console.WriteLine("CORRECT");
        Console.WriteLine("congratulations you passed with two point");
        total.Add(2);
        if (question1 == "C" && question2 == "B" && question3 == "A" && question4 == "C")
        {
            Console.WriteLine("congratulations  your total is now  EIGHT point");
        }
        else
        {
            Console.WriteLine("YOU GOT -2 FROM THE FIRST POINT");
        }
    }
}

else if (question4 != "A" && question4 != "B" && question4 != "C" )
{
    Console.WriteLine("iNVALID COMMAND");
    Console.WriteLine("KINDLY CHOOSE FROM THE ABOVE OPTIONS! ");
}
else
{
    Console.WriteLine("WRONG");
    Console.WriteLine("you failed and couldn't get any point");
}

Console.WriteLine("LAST QUESTION");

Console.WriteLine("5. Without bringing you fack mask  and your handbook,Can you enter the hall?");
Console.WriteLine("A, true");
Console.WriteLine("B, false");
Console.WriteLine("C, it's not compuslory to have them");


string question5 = Console.ReadLine();
if (question5 == "C")
{
    Console.WriteLine("CORRECT");
    Console.WriteLine("congratulations you passed with two point");
    total.Add(2);
    {
        if (question1 == "C" && question2 == "B"&& question3 == "A" && question4 == "C" && question5 == "C")
        {
            Console.WriteLine("congratulations  your total is now  TEN point");
        }
        else
        {
            Console.WriteLine("YOU GOT -2 FROM THE FIRST POINT");
        }
    }
}
else if (question5 != "A" && question5 != "B" && question5 != "C")
{
    Console.WriteLine("iNVALID COMMAND");
    Console.WriteLine("KINDLY CHOOSE FROM THE ABOVE OPTIONS! ");
}
else
{
    Console.WriteLine("WRONG");
    Console.WriteLine("you failed and couldn't get any point");
}
if (total.Count > 6)
{
    Console.WriteLine($"Bravo, your scored {total.Sum()}");
}
else
{
    Console.WriteLine($"Nice try but improve on yourself, your score {total.Sum()} MARKS!");
}



