using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabledGame
{
    internal class SG
    {
        public string wordss;
        public string firstattempts;
        public string answers;

        public SG(string v1, string v2, object value)
        {
            this.wordss = v1;
            this.firstattempts = v2;
            this.answers = value;
        }

        public class words
        {
            public string word { get; set; }
            public string first_attempt { get; set; }

            public string answer { get; set; }

            public string answerProperty
            {
                get { return answer; }
                set
                {
                    if (value != "do" || value != "as")
                    {
                        answer = value;
                    }
                    else
                    {
                        Console.WriteLine("failed");
                    }
                }

            }

        }
        public class totalsum 
        {
            public string Addsum(words[] arrwords)
            {
                string area = "";

                foreach (var objword in arrwords)
                { 
                
                    area += objword.first_attempt  + objword.answer;
                    if (objword.first_attempt != objword.answer)
                        return area;
                    else
                        Console.WriteLine("next attempt");
                    break;
                }
             
                return area; 
            }
        }
    }
}
