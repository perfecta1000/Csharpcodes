using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fieldsandproperty_classwork
{
    internal class human
    {
        private int eye;
        private int leg;
        private int teeth;
        public string colour { get; set; }


        public int eyeProperty
        {
            get { return eye; }
            set 
            {
                if (value < 2 || value > 2)
                {
                    eye = 2;
                }
                else
                { 
                    eye = value;
                }
            }
        }

        public int legProperty
        {
            get { return leg; }
            set
            {
                if (value != 2 )
                {
                    leg = 2;
                }
                else
                {
                    leg = value;
                }
            }
        }

        public int teethProperty
        {
            get { return teeth; }
            set
            {
                if (value > 32)
                {
                    teeth = 32;
                }
                else
                {
                    teeth = value;
                }
            }
        }

    }
}
