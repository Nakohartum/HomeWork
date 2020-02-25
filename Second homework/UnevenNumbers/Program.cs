using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnevenNumbers
{
    class Program
    {
        static void unevenNumber()
        {
            int a = 0;
            int b = 0;
            while (true)
            {
                Console.WriteLine("Write your number");
                a = Convert.ToInt32(Console.ReadLine());
                if (a != 0)
                {
                    if (a % 2 == 1)
                    {
                        b+= a;
                    }
                    else
                    {
                        break;
                    }
                }              
            }
            Console.WriteLine($"Your sum is {b}");
        }
        static void Main(string[] args)
        {
            Console.Title = "Artyom Khairulin, KZ";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            unevenNumber();
            Console.ReadKey();
        }
    }
}
