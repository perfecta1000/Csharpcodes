
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int total = 0;
int grandtotal = 0;

while (true)
{
    Console.WriteLine("FIRST QUESTION");
    question("1 .All of these helps in writing exam except?.", "  pen","  Pencil", "  cloth");
    string ques1 = Console.ReadLine();
    if (ques1 == "C")
    {
        Console.WriteLine("CORRECT!");
        Console.WriteLine("congratulations you passed with two point");
        grandtotal++;
    }

    else if (ques1 != "A" && ques1 != "B" && ques1 != "C")
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
    question1("2.Before you can browse the internet you must use data ?.", "false", "true");
    string quest1 = Console.ReadLine();
    {
        if (quest1 == "B")
        {
            Console.WriteLine("CORRECT");
            Console.WriteLine("congratulations you passed with two point");
             grandtotal++;
            if (quest1 == "B" && ques1 == "C")
            {
                Console.WriteLine("congratulations your total is now FOUR point");
            }
            else
            {
                Console.WriteLine("YOU GOT -2 FROM THE FIRST POINT");
            }
        }

        else if (quest1 != "A" && quest1 != "B")
        {
            Console.WriteLine("iNVALID COMMAND");
            Console.WriteLine("KINDLY CHOOSE FROM THE ABOVE OPTIONS! ");
        }

        else
        {
            Console.WriteLine("WRONG");
            Console.WriteLine("you failed and couldn't get any point");
        }
    }
    Console.WriteLine("THIRD QUESTION");
    question1("3. wihtout writing jamb and post utme you cant enter into the university " ," True ", " false");
    string quest2 = Console.ReadLine();
    if (quest2 == "A")
    {
        {
            Console.WriteLine("CORRECT");
            Console.WriteLine("congratulations you passed with two point");
            grandtotal++;
            if (ques1 == "C" && quest1 == "B" && quest2 == "A")
            {
                Console.WriteLine("congratulations  your total is now  SIX point");
            }
            else
            {
                Console.WriteLine("YOU GOT -2 FROM THE FIRST POINT");
            }
        }
    }
    else if (quest2 != "A" && quest2 != "B")
    {
        Console.WriteLine("iNVALID COMMAND");
        Console.WriteLine("KINDLY CHOOSE FROM THE ABOVE OPTIONS! ");
    }
    else
    {
        Console.WriteLine("WRONG");
        Console.WriteLine("you failed and couldn't get any point");
    }
    Console.WriteLine("Two more  QUESTIONS left");
    question("4.living with an  infected person with HIV you may be likly to contact", " True ", " false", "Not llikely to have");
    string ques2 = Console.ReadLine();

    if (ques2 == "C")
    {
       Console.WriteLine("CORRECT");
       Console.WriteLine("congratulations you passed with two point");
       grandtotal++;
       if (ques2 == "C" && ques1 == "C" && quest1 == "B" && quest2 == "A")
       {
       Console.WriteLine("congratulations  your total is now  EIGHT point");
       }
       else
       {
       Console.WriteLine("YOU GOT -2 FROM THE FIRST POINT");
       }
    }

    else if (ques2 != "A" && ques2 != "B" && ques2 != "C")
    {
        Console.WriteLine("iNVALID COMMAND");
        Console.WriteLine("KINDLY CHOOSE FROM THE ABOVE OPTIONS! ");
    }
    else
    {
        Console.WriteLine("WRONG");
        Console.WriteLine("you failed and couldn't get any point");
    }

}


static void question( string ques, string option1, string option2, string option3)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine(ques);
    Console.WriteLine("A" + option1);
    Console.WriteLine("B" + option2);
    Console.WriteLine("C" + option3);
}

static void question1(string quest, string option1, string option2)
{
    Console.BackgroundColor= ConsoleColor.Green;
    Console.WriteLine(quest);
    Console.WriteLine("A" + option1);
    Console.WriteLine("B" + option2);
}