// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Abigial","Ocheke", "SS2",89.5),
                new Student("sonia","oqwuche", "SS1",79.5),
                new Student("shedrack","Ogbole", "JSS1",50.5),
                new Student("Isaac","Ugbabe", "JSS1",49.5),
                new Student("Samuel","Ajebi", "SS1",59.5),
                new Student("Patrick","Eneche", "SS1",69.5),
                new Student("Esther","Oyikwu", "SS2",89.5),
            };
            //var querySyntax = from student in students
            //                  where student.CurrentClass == "JSS1" && student.ResultAverage >=50
            //                  select student;

            //foreach (var student in querySyntax)
            //{
            //    Console.WriteLine($"Firstname: {student.Firstname}, Surname: {student.Surname}, Class: {student.CurrentClass}, Average: {student.ResultAverage}.");
            //}

            //var methodSyntax = students.Where(obj => obj.CurrentClass == "JSS1" && obj.ResultAverage >=50);


            //var mixedSyntax = (from student in students
            //                   where student.CurrentClass == "JSS1" &&  student.ResultAverage >= 50
            //                   select student.ResultAverage).Max();
            //Console.WriteLine(mixedSyntax);
            //foreach (var st in methodSyntax)
            //{
            //    Console.WriteLine($"Firstname: {st.Firstname}, Surname: {st.Surname}, Class: {st.CurrentClass}, Average: {st.ResultAverage}.");
            //}

            var basicQuery = (from emp in students
                              select new
                              {
                                  CurrentClass = emp.CurrentClass,

                                  Surname = emp.Surname,
                              }).ToList();



            foreach (var query in basicQuery)
            {
                Console.WriteLine($"  surname = {query.Surname} class =  {query.CurrentClass} ");

            }



            Console.ReadLine();
        }

        
    }
}