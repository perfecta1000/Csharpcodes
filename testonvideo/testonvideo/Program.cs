using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testonvideo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //answer one
            // 1. Oftype 
            // 2. where

            // answer two
            // 1. select
            // 2. selectMany

            //answer 3a
            List<object> list = new List<object>() { 1, 2, 3, 4, 5, "esther", "grace", "grace", "blessing" };

            //answer 3b
            List<vidoetext> list1 = new List<vidoetext>()
            {
            new vidoetext()
            {
                id = 1,
                firstname="esther",
            },
            new vidoetext()
            {
                id=2,
                firstname="abigail",
            }
            };

            var ms = list1.Select(names => names.firstname).ToList();
            Console.ReadLine();
            // answer 3c
            List<string> list4 = new List<string>() { "esther", "grace", "peace", "blessing" };
            var m1 = list4.Where(tex1 => tex1.Length > 5).ToList();
            Console.ReadLine();
            // answer 4
            // sorting operators helps to manage data in a particular order
            // 1. Orderby
            // 2. OrderbyDecsending
            // 3. Thenby
            // 4. ThenbyDecsending
            // 5. Reverse.

            // answer 5
            List<int> list2 = new List<int>() { 1, 5, 4, 2, 7, 9, 24, 12, 67, 34 };
            var ms2 = list2.OrderBy(lis => lis).ToList();
            var ms3 = list2.OrderByDescending(lis => lis).ToList();
            Console.ReadLine();

            //answer 6
            var Tes = new List<vidoetext>()
            {
            new vidoetext()
            {
                firstname = "smith",
                secondname = "ogbu",
            },
            new vidoetext()
            {
                 firstname ="smith",
                 secondname ="ogbole",
            }
            };

            var mi = Tes.OrderBy(it => it.firstname).ThenBy(it => it.secondname).ToList();

            // answer 7
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            numbers.Reverse();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
