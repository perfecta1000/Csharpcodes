// See https://aka.ms/new-console-template for more information
namespace simplied_quizz_app_using_class 
{
    class Program
    {
        static void Main(string[] args)
        {
            List<QuizzQuestion> ques = new List<QuizzQuestion>()
            {
            new QuizzQuestion("stand","and","sand","patrick","abigial","A"),
            new QuizzQuestion("Your favorite food is","rice","yam","spag","swallow","C"),
            new QuizzQuestion("who program facebook", "Mark", "bread", "mercy", "sonia", "A"),

            };

            int totalgrade = 0;

            foreach(var que in ques)
            {
                Askquestion(que);
                totalgrade += CheckAnswer(que.Answer);
                
            }

            Console.WriteLine("Your total is:" +totalgrade);
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
           
            static void Askquestion(QuizzQuestion que)
            {
                Console.WriteLine(que.Question);
                //Console.WriteLine("A)"+ que.OptionA);
                //Console.WriteLine("B)" + que.OptionB);
                //Console.WriteLine("C)" + que.OptionC);
                //Console.WriteLine("D)" + que.OptionD);
                Console.WriteLine("Enter option: ");

            }
            


            //QuizzQuestion question1 = new QuizzQuestion();
            //question1.Question = "what is your name";
            //question1.OptionA = "Esther";
            //question1.OptionB = "samuel";
            //question1.OptionC = "patrick";
            //question1.OptionD = "abigial";
            //question1.Answer = "Esther";

         

            //QuizzQuestion question2 = new QuizzQuestion();
            //question2.Question = "Your favorite food is";
            //question2.OptionA = "rice";
            //question2.OptionB = "yam";
            //question2.OptionC = "spag";
            //question2.OptionD = "swallow";
            //question2.Answer = "spag";

            //QuizzQuestion question3 = new QuizzQuestion("who program facebook", "Mark", "bread", "mercy", "sonia", "esther");
           

        }
    }
}


