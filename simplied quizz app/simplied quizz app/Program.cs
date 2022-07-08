// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.BackgroundColor = ConsoleColor.DarkBlue;
int total = 0;
int grandtotal = 0;
int Attemptleft = 5;


List<string> Esther = new List<string>();

while (true)
{
    Console.WriteLine("Your Registration number is needed! Kindly enter it ");
    Esther.Add("111");
    Esther.Add("222");
    Esther.Add("333");
    Esther.Add("444");
    Esther.Add("555");

    for (int num1 = 1; num1 <= 5; num1++)
    {
        string num = Console.ReadLine();

        if (Esther.Contains(num))
        {
            Console.WriteLine();

            Console.WriteLine(" welcome! your have now successfully loggin ");
            if (Esther.Contains(num))
            {
                bool finish = false;
                Console.WriteLine("FIRST QUESTION");
               
                question("1 .All of these helps in writing exam except?.", "  pen", "  Pencil", "  cloth");
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

                if (quest1 == "B")
                {
                    Console.WriteLine("CORRECT");
                    Console.WriteLine("congratulations you passed with two point");
                    grandtotal++;
                    {
                        if (quest1 == "B" && ques1 == "C")
                        {
                            Console.WriteLine($"congratulations your total is now {grandtotal + 2}point");
                        }

                        else if(ques1 =="A"|| ques1 == "B"|| quest1=="A" || quest1=="C")
                        {
                          Console.WriteLine($"YOU GOT {grandtotal - 2} FROM THE FIRST POINT");
                        }
                        else
                        {
                            Console.WriteLine($"");
                        }
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
                Console.WriteLine("THIRD QUESTION");
                question1("3. wihtout writing jamb and post utme you cant enter into the university ", " True ", " false");
                string quest2 = Console.ReadLine();
                if (quest2 == "A")
                {
                    Console.WriteLine("CORRECT");
                    Console.WriteLine("congratulations you passed with two point");
                    grandtotal++;
                    {
                        if (ques1 == "C" && quest1 == "B" && quest2 == "A")
                        {
                            Console.WriteLine($"congratulations  your total is now  {grandtotal +2} point");
                        }
                        else if (ques1 == "B" || quest1 == "C" || quest2 =="B" )
                        {
                            Console.WriteLine($"YOU GOT {grandtotal - 2} FROM THE FIRST POINT");
                        }
                        else
                        {
                            Console.WriteLine("");
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
                    {
                        if (ques2 == "C" && ques1 == "C" && quest1 == "B" && quest2 == "A")
                        {
                            Console.WriteLine("congratulations  your total is now  EIGHT point");
                        }
                        else
                        {
                            Console.WriteLine("YOU GOT -2 FROM THE FIRST POINT");
                        }
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


                Console.WriteLine("LAST QUESTIONS left");
                question("5.Without bringing you fack mask  and your handbook,Can you enter the hall?", " True ", " false", "Its not compulsory to have them");
                string ques3 = Console.ReadLine();

                if (ques3 == "C")
                {
                    Console.WriteLine("CORRECT");
                    Console.WriteLine("congratulations you passed with two point");
                    grandtotal++;
                    {
                        if (ques2 == "C" && ques1 == "C" && quest1 == "B" && quest2 == "A" && ques3 == "C")
                        {
                            Console.WriteLine("congratulations  your total is now  TEN point");
                        }
                        else
                        {
                            Console.WriteLine("YOU GOT -2 FROM THE FIRST POINT");
                        }
                    }
                }
                else if (ques3 != "A" && ques3 != "B" && ques3 != "C")
                {
                    Console.WriteLine("iNVALID COMMAND");  
                    Console.WriteLine("KINDLY CHOOSE FROM THE ABOVE OPTIONS! ");
                }
                else
                {
                    Console.WriteLine("WRONG");
                    Console.WriteLine("you failed and couldn't get any point");
                }
                Console.WriteLine(" ");
                finish = true;

                Console.WriteLine($"Total score = {grandtotal * 2}");
                Console.WriteLine(" ");
                break;
            }
            else
            {
                Console.WriteLine("INVALID REGISTRATION NUMBER, IT DOES NOT EXIT ");
               
            }
        }
        else  
        {
            Console.WriteLine("INVALID REGISTRATION NUMBER, IT DOES NOT EXIT ");
            Console.WriteLine($"You have {Attemptleft = Attemptleft - 1} attempt left");
        }

        if (!Esther.Contains(num) && num1 >= 5)
        {
            Console.WriteLine("blocked");
        }
    }
    break;


    static void question(string ques, string option1, string option2, string option3)
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(ques);
        Console.WriteLine("A" + option1);
        Console.WriteLine("B" + option2);
        Console.WriteLine("C" + option3);
    }

    static void question1(string quest, string option1, string option2)
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(quest);
        Console.WriteLine("A" + option1);
        Console.WriteLine("B" + option2);
    }


}
