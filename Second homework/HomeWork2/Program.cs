using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static double minimalValue(double a, double b, double c)
        {
            if(a > b && a > c)
            {
                return a;
            }
            if( b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Artyom Khairulin, KZ";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Enter three values:");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            double max = minimalValue(a, b, c);
            Console.WriteLine($"Maximum value is {max}");
            Console.ReadKey();
        }
    }
}
