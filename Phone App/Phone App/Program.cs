// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome to phone book!");

while (true)

{
    Dictionary<string, string> phonebook = new Dictionary<string, string>();
    while (true)
    {
        Console.WriteLine(" Kindly specify what you will mn" +
            "" +
            "like to do Save, View, Update, Delete");
        string phoneapp = Console.ReadLine();

        if (phoneapp == "save")
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter  the number");
            string number = Console.ReadLine();
            phonebook.Add(name, number);
            Console.WriteLine( name + " sucessfully saved");
        }


        else if (phoneapp == "view")
        {

            Console.WriteLine("Enter the contact name to view");
            string contact = Console.ReadLine();
            if (phonebook.ContainsKey(contact))
            {
                Console.WriteLine(phonebook[contact]);
            }
            else
            {
                Console.WriteLine("invalid contact");
            }
        }

        else if (phoneapp == "update")
        {
            Console.WriteLine("Enter the contact name to update");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the new number  to update");
            string number = Console.ReadLine();
            phonebook[name] = number;
            Console.WriteLine(phonebook[name]);
            Console.WriteLine("number updated sucessfully");

        }

        else if (phoneapp == "delete")
        {
            Console.WriteLine("Enter name to delete");
            string name = Console.ReadLine();
            phonebook.Remove(name);
            Console.WriteLine(" The number has been deleted sucessfully");
        }

        else
        {
            Console.WriteLine("invalid command");
        }
    }
}