using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class wordscal
    {
        public string Totalword(answer[] arranswers)
        {
            //string[] words = arrwords.Select(x => x.ToString()).ToArray();
            string total= "";

            foreach (var objanswer in arranswers)
            { 
              total += objanswer.answers();
            }
            return total;
        }
    }
}
