// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqquantifier
{
    class program
    {
        static void Main(string[] args)
        {
            List<Employer> Basicone = new List<Employer>()
             {
              new Employer() {id = 1, studentname ="Esther",Gender ="female",
                  Subjects = new List<Subjects>(){
                        new Subjects(){Subjectname ="maths", Subjectmark = 45 },
                        new Subjects(){Subjectname ="english", Subjectmark = 55 },
                  } },
              new Employer () {id = 2, studentname = "john", Gender = "male",
              Subjects = new List<Subjects>(){
                   new Subjects(){Subjectname ="maths", Subjectmark = 45 },
                    new Subjects(){Subjectname ="chem", Subjectmark = 65 },
               } },

              
              
             };
            var ms = Basicone.Where(sub => sub.Subjects.All(sub => sub.Subjectmark >70)).Select(sub => sub.Subjects).ToList();

            var mis = Basicone.Where(sub => sub.Subjects.Any(sub => sub.Subjectname == "maths")).Select(sub => sub.studentname).ToList();

            var comparer = new Employer();
            var check = Basicone.Contains(new Employer()
            {
                id = 1,
                studentname = "Esther",
                Gender = "female",
                Subjects = new List<Subjects>() {
                    new Subjects() { Subjectname = "maths", Subjectmark = 45 },
                    new Subjects() { Subjectname = "english", Subjectmark = 55 },
                },
            } );
            Basicone.Add(comparer);
            var exit = Basicone.Contains(comparer);
            

            Console.ReadLine();
        }
    }
    class Employer
    {
        public int id { get; set; }
        public string studentname { get; set; }
        public string Gender { get; set; }

        public List<Subjects> Subjects { get; set; }
        
    }
    class Subjects
    {
        public string Subjectname { get; set; }
        public int Subjectmark { get; set; }
    }


}

