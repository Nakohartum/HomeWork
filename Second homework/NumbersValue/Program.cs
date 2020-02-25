using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersValue
{
    class Program
    {
        static int numbersCount(int a)
        {
            int i = 0;
            
            while(a > 0)
            {
                a = a / 10;
                i++;
            }
            return i;
        }
        static void Main(string[] args)
        {
            Console.Title = "Artyom Khairulin, KZ";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Enter the value:");
            int a = Int32.Parse(Console.ReadLine());
            int counter = numbersCount(a);
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
