       // See https://aka.ms/new-console-template for more information

namespace Debugging 
{
    class program 
    {
        public static void Main(string[] args)
        {

            string mess1 = message.GetMessage("yoruba");
            Console.WriteLine(mess1);

            string messae = message.GetMessage("hausa");
            Console.WriteLine(messae);
         
            string mess = message.GetMessage("igbo");
            Console.WriteLine(mess);

            string me = message.GetMessage("English");
            Console.WriteLine(me);

            string mes2 = message.GetMessage("hghg");
            Console.WriteLine(mes2);
            Console.ReadLine();

        }
    } 
}
