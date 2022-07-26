// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace linqpratice
{
    class program
    {
        static void Main(string[] args)
        {
           List<basic> list = new List<basic>();
            {
                new basic("Abigial", "Ocheke", "SS2", 89.5);
                new basic("sonia", "oqwuche", "SS1", 79.5);
                new basic("shedrack", "Ogbole", "JSS1", 50.5);
                new basic("Isaac", "Ugbabe", "JSS1", 49.5);
                new basic("Samuel", "Ajebi", "SS1", 59.5);
                new basic("Patrick", "Eneche", "SS1", 69.5);
                new basic("Esther", "Oyikwu", "SS2", 89.5);

                var basicQuery = (from emp in list
                                 select new 
                                 {
                                     CurrentClass = emp.CurrentClass,
                                     
                                     Surname=emp.Surname,
                                 }).ToList();

                var datasource = new List<string>()
                {

                };



                foreach (var query in basicQuery)
                {
                    Console.WriteLine($"  surname = {query.Surname} class =  {query.CurrentClass} ");
                
                }
            };
        }
    }
}