// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
namespace LIBRARY
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                             WELCOME TO THE LIBRARY APPLICATION \n\n");
            int choose;

            Console.Write("                     ENTER [1] TO BORROW A BOOK OR [2] TO RETURN A BOOK BORROWED \n");

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

                Dictionary<string, string> books = new Dictionary<string, string>();
                books.Add("1","squid game" );
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

                    if (books.ContainsKey(op))
                    {
                        books.Remove(op);
                        Console.WriteLine($"{op} HAS BEEN SUCCESFULLY BORROWED OUT!! \n");
                        Console.WriteLine("THE LIST OF THE REMAINING BOOKS ARE BELOW");
                    }
                    else
                    {
                        Console.WriteLine("the book is not in the library");
                    }
                    foreach (var book in books)
                    {
                        Console.WriteLine(book);

                    }
                }
                //string op1 = Console.ReadLine();
                //if (books.Contains(op1))
                //{
                //    books.Remove(op1);
                //    Console.WriteLine($"{op1} HAS BEEN SUCCESFULLY BORROWED OUT!! \n");
                //    Console.WriteLine("THE LIST OF THE REMAINING BOOKS ARE BELOW");
                //}
                //foreach (var book in books)
                //{
                //    Console.WriteLine(book);

                //}

                //string op2 = Console.ReadLine();
                //if (books.Contains(op2))
                //{
                //    books.Remove(op2);
                //    Console.WriteLine($"{op2} HAS BEEN SUCCESFULLY BORROWED OUT!! \n");
                //    Console.WriteLine("THE LIST OF THE REMAINING BOOKS ARE BELOW");
                //}
                //foreach (var book in books)
                //{
                //    Console.WriteLine(book);

                //}

                //string op3 = Console.ReadLine();
                //if (books.Contains(op3))
                //{
                //    books.Remove(op3);
                //    Console.WriteLine($"{op3} HAS BEEN SUCCESFULLY BORROWED OUT!! \n");
                //    Console.WriteLine("THE LIST OF THE REMAINING BOOKS ARE BELOW");
                //}
                //foreach (var book in books)
                //{
                //    Console.WriteLine(book);

                //}

                //string op4 = Console.ReadLine();
                //if (books.Contains(op4))
                //{
                //    books.Remove(op4);
                //    Console.WriteLine($"{op4} HAS BEEN SUCCESFULLY BORROWED OUT!! \n");
                //    Console.WriteLine("THE LIST OF THE REMAINING BOOKS ARE BELOW");
                //}
                //foreach (var book in books)
                //{
                //    Console.WriteLine(book);

                //}
                //string op5 = Console.ReadLine();
                //if (books.Contains(op5))
                //{
                //    books.Remove(op5);
                //    Console.WriteLine($"{op5} HAS BEEN SUCCESFULLY BORROWED OUT!! \n");

                //}
                //foreach(var book in books)
                //{
                //    Console.WriteLine(book);
                //    Console.WriteLine("WELDONE ALL THE BOOK HAVE BEEN BORROWED");
                //}


            }

            static void Returnbook()
            {

            }
        }
    }
}
