using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqpratice
{
    internal class basic
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string CurrentClass { get; set; }
        public double ResultAverage { get; set; }

        public basic(string Fname, string Sname, string Cclass, double RAverage)
        {
            Firstname = Fname;
            Surname = Sname;
            CurrentClass = Cclass;
            ResultAverage = RAverage;
        }
    }
}
