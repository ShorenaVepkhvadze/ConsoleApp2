using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HomeworkFour
    {
        static void Main(string[] args)
        {
            //დავალება#1
            Console.WriteLine(Sum(15, 20));

            // დავალება#2
            Console.WriteLine("Enter number#1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number#2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number#3: ");
            double x3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number#4: ");
            double x4 = double.Parse(Console.ReadLine());

            // გამოვიძახოთ მეთოდი რომელიც მინიმუმს და მაქსიმუმს გამოიყვანს
            MinMax(x1, x2, x3, x4);

            //დავალება#3   
            Fruit();



        }

        //1. შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს.
        //მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი.
        //გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.

        static int Sum(int x, int y)
        {

            int result = x + y;
            return result;

        }
        // 2. შევქმნათ მეთოდი. ვთხოვოთ მომხმარებელს შეიყვანოს ოთხი ნებისმიეირ ტიპის რიცხვი (ანუ არა მხოლოდ ინტეჯერი).
        // მეთოდის ფარგლებში უნდა მოიძებნოს ამ ოთხი რიცხვიდან ყველაზე დიდი და ყველაზე პატარა.
        // მეთოდმა უნდა გამოიყვანოს კონსოლში ეს ორი რიცხვი.
        static void MinMax(double x1, double x2, double x3, double x4)
        {
            if (x1 > x2 && x1 > x3 && x1 > x4)
            {
                Console.WriteLine("The Max number: " + x1);
            }
            else if (x2 > x1 && x2 > x3 && x2 > x4)
            {
                Console.WriteLine("The Max number: " + x2);
            }
            else if (x3 > x1 && x3 > x1 && x3 > x4)
            {
                Console.WriteLine("The Max number: " + x3);
            }
            else if (x4 > x1 && x4 > x2 && x4 > x3)
            {
                Console.WriteLine("The Max number: " + x4);
            }
            else
            {
                Console.WriteLine("Numbers is equal");
            }

            if (x1 < x2 && x1 < x3 && x1 < x4)
            {
                Console.WriteLine("The Min number: " + x1);
            }
            else if (x2 < x1 && x2 < x3 && x2 < x4)
            {
                Console.WriteLine("The Min number: " + x2);
            }
            else if (x3 < x1 && x3 < x2 && x3 < x4)
            {
                Console.WriteLine("The Min number: " + x3);

            }
            else if (x4 < x1 && x4 < x2 && x4 < x3)
            {
                Console.WriteLine("The Min number: " + x3);
            }
            else
            {
                Console.WriteLine("Numbers is Equal");
            }
        }

        //შევქმნათ მეთოდი, რომელმაც უნდა მიიღოს მეორე მეთოდის მეშვეობით მომხმარებლისგან ხილის დასახელება.
        //ამ ხილის დასახელების მიღების შემდეგ switch ოპერატორის მეშვეობით ნახოს თუ რომელი ხილია და გამოიყვანოს შესაბამისი შეტყობინება. თუ ასეთი ხილი არ მოიძებნა, ამის შესახებაც მომხმარებელმა უნდა მიიღოს შეტყობინება.
        //ხილი: apple, watermelon, melon, cherry, strawberry. 


        static void Fruit()
        {
            Console.WriteLine("Enter your Fruit: ");
            string FruitInput = Console.ReadLine();
            switch (FruitInput)

            {
                case "apple":
                    Console.WriteLine("This is a Apple");
                    break;
                case "watermelon":
                    Console.WriteLine("This is a watermelon");
                    break;
                case "melon":
                    Console.WriteLine("This is a melon");
                    break;
                case "cherry":
                    Console.WriteLine("This is a cherry");
                    break;
                case "stawberry":
                    Console.WriteLine("This is an strawberry");
                    break;
                default:
                    Console.WriteLine("There is no such fruit");
                    break;
            }
        }

    }
}
