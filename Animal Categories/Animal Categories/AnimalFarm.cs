using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Categories
{
    internal class AnimalFarm
    {
        public string Name { get; set; }
        public string habitat { get; set; }
        public string Feeding { get; set; }
        public bool Movement { get; set; }
        public string category { get; set; }
        public string Reproduction { get; set; }

        public AnimalFarm()
        {

        }

        public AnimalFarm(string Myname, string Myhabitat, string Myfeeding, bool Mymovement, string Mycategory, string Myreproduction)
        {
            Name = Myname;
            habitat = Myhabitat;
            Feeding = Myfeeding;
            Movement = Mymovement;
            this.category = Mycategory;
            Reproduction = Myreproduction;
        } 

    }

}
