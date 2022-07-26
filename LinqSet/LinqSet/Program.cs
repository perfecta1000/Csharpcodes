using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() {1,2,5,5,6,7,8,4,6,6,3,10 };
            List<int> Numbers1 = new List<int>() { 2, 5, 8, 12, 4, 67, 9, 5 };

            var ms = Numbers.Distinct().OrderBy(lis => lis).ToList();

            var mis = Numbers.Except(Numbers1).OrderBy(lis => lis).ToList();

            var mise = Numbers.Intersect(Numbers1).OrderBy(lis => lis).ToList();

            var mised = Numbers.Union(Numbers1).OrderByDescending(lis => lis).ToList();

            Console.ReadLine();
        }
    }
}
