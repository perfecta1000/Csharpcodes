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
            string[] Roots = Directory.GetFiles(Root, "*.JPG");
            string newpath = @"C:\Users\Student\Downloads\ImageFolder\";

            if (Roots.Length == 0)
            {
                Console.WriteLine("No image is remaining");
            }
            else
            {
                foreach (string file in Roots)
                {
                    if (Directory.Exists(newpath))
                    {
                        try
                        {
                            File.Move(file, $"{newpath}{Path.GetFileName(file)}");
                            Console.WriteLine("successful");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("image already exists in both folder ");
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(newpath);
                        File.Move(file, $"{newpath}{Path.GetFileName(file)}");
                    }
                    
                }
            }
        Console.ReadLine();
        }
    }
}
