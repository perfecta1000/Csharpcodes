// See https://aka.ms/new-console-template for more information
Console.WriteLine("WELCOME!");
Console.WriteLine("KINDLY GET STARTED WITH YOUR QUIZZ");

Dictionary<string, int> QUIZZ = new Dictionary<string, int>();
Console.WriteLine("YOUR HAVE 10 QUESTIONS TO ANSWER IN THIS SECTION");
QUIZZ.Add(question1, 1);
QUIZZ.Add(question2, 2);
QUIZZ.Add(question3, 3);
QUIZZ.Add(question4, 4);
QUIZZ.Add(question5, 5);

        Console.WriteLine("1.All of these helps in writing exam except?");
        Console.WriteLine("A, pen");
        Console.WriteLine("B, pencil");
        Console.WriteLine("C, cloth");

        string question1 = Console.ReadLine();

        if (question1 == "C")
        {
            Console.WriteLine("congratulations you passed with one point");

        }
        else
        {
            Console.WriteLine("you failed and couldn't get any point");
        }

        Console.WriteLine("2. Before you can browse the internet you must use data?");
        Console.WriteLine("A, false");
        Console.WriteLine("B, true");

        string question2 = Console.ReadLine();

        if (question2 == "B")
        {
            Console.WriteLine("congratulations you passed with one point");
        }

        else
        {
            Console.WriteLine("you failed and couldn't get any point");
        }

        Console.WriteLine("3. wihtout writing jamb and post utme you cant enter into the university");
        Console.WriteLine("A, true");
        Console.WriteLine("B, false");

        string question3 = Console.ReadLine();

        if (question3 == "A")
        {
            Console.WriteLine("congratulations you passed with one point");
        }
        else
        {
            Console.WriteLine("you failed and couldn't get any point");
        }

        Console.WriteLine("4.living with an  infected person with HIV you may be likly to contact");
        Console.WriteLine("A, true");
        Console.WriteLine("B, false");
        Console.WriteLine("C, Not likly to have");

        string question4 = Console.ReadLine();

        if (question4 == "C")
        {
            Console.WriteLine("congratulations you passed with one point");
        }
        else
        {
            Console.WriteLine("you failed and couldn't get any point");
        }
        Console.WriteLine("5. Without bringing you fack mask  and your handbook,Can you enter the hall?");
        Console.WriteLine("A, true");
        Console.WriteLine("B, false");
        Console.WriteLine("C, it's not compuslory to have them");

        string question5 = Console.ReadLine();

        if (question5 == "C")
        {
            Console.WriteLine("congratulations you passed with one point");
        }
        else
        {
            Console.WriteLine("you failed and couldn't get any point");
        }

Console.Writeline("congratulations you passed all with 5 point");

 