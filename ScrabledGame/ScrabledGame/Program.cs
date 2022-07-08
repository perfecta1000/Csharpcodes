
// See https://aka.ms/new-console-template for more information
namespace ScrabledGame 
{
    class program
    {
        static void Main(string[] args)
        {
            List<SG> ONE = new List<SG>();
            new SG("fd", "", "");
            int totalgrade = 0;

            foreach (var que in ONE)
            {
                Askquestion(que);
                totalgrade += CheckAnswer(que.answers);

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


                static void Askquestion(SG ques)
                {
                    Console.WriteLine(ques.wordss);
                    Console.WriteLine(ques.firstattempts);
                    Console.WriteLine(ques.answers);
                  

                }
            }
        }
    }
}
