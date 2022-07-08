using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carclass
{
    internal class Car
    {

        public int platenumber;
        public string brand;
        public int speed;
        public string colour;
        public string efficiency;

        public Car()
        { }

        public Car( int pd, string bd, int sd, string cr, string ey )
        {
            platenumber = pd;
            brand = bd;
            speed = sd;
            colour = cr;
            efficiency = ey;

        }
    }
}
