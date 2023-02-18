using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercise #1");

            int x = 4;
            int z = 5;
            int y = 10;
            Console.WriteLine(x + y * z);


            Console.WriteLine();
            Console.WriteLine("exercise #2");

            Console.WriteLine("Please, enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Please, enter your surname:");
            string surname = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Please, enter your age:");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please, enter your height:");
            double height = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please, enter your weight:");
            double weight = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(name + " " + surname + " " + "myAge=" + age + " " + "myHeight=" + height + " " + "myWeight=" + weight);

            Console.WriteLine();
            Console.WriteLine("exercise #3");

            double Myheight = 175;
            double Myweight = 79.5;
            double MBI = (Myweight / (Myheight/100 * Myheight /100));
            Console.WriteLine(MBI);

            Console.WriteLine();
            Console.WriteLine("exercise #4");

            Console.WriteLine(" " + "|" + " " + "|" + " ");
            Console.WriteLine("1" + "|" + "2" + "|" + "3");
            Console.WriteLine("_" + "|" + "_" + "|" + "_");
            Console.WriteLine(" " + "|" + " " + "|" + " ");
            Console.WriteLine("4" + "|" + "5" + "|" + "6");
            Console.WriteLine("_" + "|" + "_" + "|" + "_");
            Console.WriteLine(" " + "|" + " " + "|" + " ");
            Console.WriteLine("7" + "|" + "8" + "|" + "9");
            Console.WriteLine(" " + "|" + " " + "|" + " ");


        }

    }
}
