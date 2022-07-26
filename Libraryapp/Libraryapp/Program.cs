// See https://aka.ms/new-console-template for more information
namespace Libraryapp
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                             WELCOME TO THE LIBRARY APPLICATION \n\n");
            int choose;

            Console.WriteLine("                     ENTER [1] TO BORROW A BOOK OR [2] TO RETURN A BOOK BORROWED \n");

            try
            {
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Borrowbook();

                        break;

                    case 2:
                        Returnbook();

                        break;
                         
                    default:
                        Console.WriteLine("Kindly choose from the given options.");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Input!!! Kindly select from the given one's");

            }
            finally
            {
                Console.WriteLine("Thank you for using the libray");
            }
            static void Borrowbook()
            {
                Console.WriteLine("                  Welcome Kindly choose from the below books to borrow any of them \n");

                List<string> books = new List<string>();
                books.Add("SQUID GAME");
                books.Add("SUICIDE SQUAD");
                books.Add("NO TIME TO DIE");
                books.Add("REVENGE");
                books.Add("BAD BOYS FOR LIFE");
                while (true)
                {
                    foreach (var book in books)
                    {
                        Console.WriteLine(book);
                    }
                    string op = Console.ReadLine();

                    if (books.Contains(op) == true)
                    {
                        books.Remove(op);
                        Console.WriteLine($"{op} HAS BEEN SUCCESFULLY BORROWED OUT!! \n");
                        Console.WriteLine("THE LIST OF THE REMAINING BOOKS ARE BELOW");
                    }
                   
                    else if (books.Count == 0)
                    {
                        Console.WriteLine("Empty Libraby!!!All books have been borrowed \n");
                    }
                    else if  (books.Contains(op) == false)
                    {
                        Console.WriteLine("WRONG INPUT!!! PLEASE ENTER THE CORRECT BOOK \n");
                    }

                }
            }
            static void Returnbook()
            {
                Console.WriteLine("                  Welcome  back !!! kindly Enter the day that you borrowed you book \n");
                while (true)
                {
                    string returnbook = Console.ReadLine();
                    if (int.Parse(returnbook) <= 10)
                    {
                        Console.WriteLine("Congratulations you have no fine attached to your book");
                        break;
                    }
                    else if (int.Parse(returnbook) >= 11 && int.Parse(returnbook) <= 30)
                    {
                        int book2 = int.Parse(returnbook) - 10;
                        Console.WriteLine($"YOUR CHARGED FINE IS {(book2) * 50}  TRY AND RETURN EARLY NEXT TIME!!!");
                        break;
                    }
                    else if (int.Parse(returnbook) >= 31)
                    {
                        int book2 = int.Parse(returnbook) - 10;
                        Console.WriteLine($"YOUR CHARGED FINE IS {(book2) * 100}  TRY AND RETURN EARLY NEXT TIME!!!");
                        break;
                    }
                }
            }
        }
    }
}


