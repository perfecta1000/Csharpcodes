using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrambled_app
{
    internal class scrambled_word
    {
        string word { get; set; }
        string first_attempt { get; set; }
        string second_attempt { get; set; }
        string third_attempt { get; set; }
        //string [] answer { get; set; }
        public static void Main()
        {
            string[] answers = new[]
            {
                "microsoft",
                "soft",
                "micro",
             };
            var rng = new Random();
            //for (int i = 0; i < answers.Length; i++)
            int Randomnumber = rng.Next( answers.Length);

            Console.WriteLine(answers[Randomnumber]);
        }



        public scrambled_word(string Word, string First_attempt, string Second_attempt, string Third_attempt, string [] Answer)
        {
            word = Word;
            first_attempt = First_attempt;
            second_attempt = Second_attempt;
            third_attempt = Third_attempt;
            //answer = Answer;
        }
        public scrambled_word()
        { }
    }
}
