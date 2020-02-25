using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static void recursive(int a, int b)
        {
            if (b > 0)
            {
                Console.WriteLine($"Your number {b}");
                recursive(a, b - 1);
            }
        }
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.Title = "Artyom Khairulin, KZ";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Write the starting number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Write the ending number");
            int b = Int32.Parse(Console.ReadLine());
            recursive(a, b);
            Console.ReadKey();
        }
    }
}
