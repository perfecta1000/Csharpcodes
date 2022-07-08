namespace Scrambled_app
{
    class program
    {
        static void Main(string[] args)
        {
            List<scrambled_word> scr = new List<scrambled_word>();
              {
                new scrambled_word("lgkjdf", "micro", "soft", "microsoft" );

              };
            Console.WriteLine(scr.word);
            string anwerg = Console.ReadLine();

            var rng = new Random();
            //for (int i = 0; i < answers.Length; i++)
            int Randomnumber = rng.Next(0, answers.Length);

            Console.WriteLine(answers[Randomnumber]);

            List<scrambled_word> firstword = new List<scrambled_word>()
            {
                 new scrambled_word("ESTHER", "Her", "The", "Rest", ""),
                 new scrambled_word("RFTOMSCIO", "Microsoft", "Soft", "Micro",""),

            };

            int totalgrade = 0;

            foreach (var que in firstword)
            {
                Askquestion(que);
                totalgrade += CheckAnswer(que.answer);

            }

            Console.WriteLine("Your total is:" + totalgrade);
            static int CheckAnswer(string correctAnswer)
            {
                string answer = Console.ReadLine();
                if (answer.Equals(correctAnswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("PASS! you have gotten 1 point");
                    return 1;
                }
                else
                {
                    Console.WriteLine("FAILED");
                    return 0;
                }
            }

            //static void Askquestion(scrambled_word ques)
            //{
            //    Console.WriteLine(ques.word);
            //    Console.WriteLine( ques.first_attempt);
            //    Console.WriteLine(ques.second_attempt);
            //    Console.WriteLine(ques.third_attempt);


        }
        
    }
}
