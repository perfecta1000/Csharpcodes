using System;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("asjkdfh");
        string user = Console.ReadLine();
        string[] answers =
        {
                    "micro",
                    "soft",
                    "microsoft"
                };
        if ( user == "microsoft" || user == "soft" || user == "micro")
        {
            Console.WriteLine("correct try another word");
        }
        else
        {
            Console.WriteLine("failed");
        }

        //string[] answers = new[]
        //{
        //    "micro",
        //    "soft",
        //    "microsoft"
        //};

        //        var rng = new Random();

        //        int randomnumber = rng.Next(answers.Length);

        //        Console.WriteLine(answers[randomnumber]);
    }
}