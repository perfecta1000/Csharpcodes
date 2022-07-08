using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class firstattempt : answer
    {
        public string question { get; set; }
        public string answer { get; set; }
        public override string answers()
        {
            return question + answer;
        }

    }
    public class secondattempt : answer
    { 
        public string question { get; set; }
        public string answer { get; set; }
        public override string answers()
        {
            return question + answer;
        }
    }
}
