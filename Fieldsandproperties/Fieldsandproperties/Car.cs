using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fieldsandproperties
{
    internal class Car
    {
        private int speed;
        private int wheel;
        public string colour;

        public int speedProperty
        {
            get { return speed; }
            set
            {
                if (value > 250)
                {
                    speed = 250;
                }
                else
                { 
                    speed = value;
                }    
            } 
        }

        public int wheelProperty
        {
            get { return wheel; }
            set 
            {
                if (value > 4)
                {
                    wheel = 4;
                }
                else
                {
                    wheel = value;
                } 
            }
            
        }

        public string colourProperty
        {
            get { return colour; }
            set
            {
                if (value != "do"|| value != "as")
                {
                    colour = value;
                }
                else
                {
                    Console.WriteLine("failed");
                }
            }

        }
    }

}
