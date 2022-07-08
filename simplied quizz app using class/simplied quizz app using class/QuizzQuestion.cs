using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplied_quizz_app_using_class
{
    internal class QuizzQuestion
    {
        public string Question { get; set; }
        
        public string Answer { get; set; }

        public QuizzQuestion(string MyQUESTION, string MyOptionA, string MyOptionB, string MyOptionC, string MyOptionD, string MyAnswer)
        {
            Question = MyQUESTION;
            OptionA = MyOptionA;
            OptionB = MyOptionB;
            OptionC = MyOptionC;
            OptionD = MyOptionD;
            Answer = MyAnswer;
            
        }
        public QuizzQuestion()
        {

        }
    }
}
