using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileMoverApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Root = @"C:\Users\Student\Downloads";
            var Roots = Directory.GetFiles(Root, "*.JPG.", SearchOption.AllDirectories);
            string newpath = @"C:\Users\Student\Downloads\ImageFolder\";
            Directory.CreateDirectory(newpath);
            string destinationfolder = @"C:\Users\Student\Downloads\ImageFolder\";
            bool directoryExits = Directory.Exists(Root);

            try
            {

                foreach (string file in Roots)
                {
                    //File.Move(file, $"{destinationfolder} {Path.GetFileName(file)}");

                    if (directoryExits)
                    {
                        File.Move(file, $"{destinationfolder} {Path.GetFileName(file)}");
                    }
                    else
                    {
                        Console.WriteLine("Images does not exist");
                    }
                }
            }
            
            catch (Exception)
            {
                Console.WriteLine("Please kindly note, you alredy have the image in both folder");
            }

            Console.ReadLine();
        }
    }
}
