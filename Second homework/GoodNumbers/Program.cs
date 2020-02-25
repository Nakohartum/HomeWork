using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNumbers
{
    class Program
    {
        static int goodNumbers()
        {
            int goodNumbers = 0;
            int minNumber = 1; // minimal number
            int maxNumber = 1000000; // the highest number
            int temp; //Sum 
            int testingNumber; // Number, which we are testing

            for (int number = minNumber; number <= maxNumber; number++)
            {
                temp = 0;
                testingNumber = number;
                while (testingNumber != 0)
                {
                    temp += testingNumber % 10;
                    testingNumber /= 10;
                }
                if (number % temp == 0) goodNumbers++;
            }
            return goodNumbers;
            
        }
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.Title = "Artyom Khairulin, KZ";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            int good = goodNumbers();
            System.Threading.Thread.Sleep(20);
            Console.WriteLine($"Good numbers are {good}");
            DateTime finish = DateTime.Now;
            Console.WriteLine($"We have finished in {start - finish} seconds");
            Console.ReadKey();
        }
    }
}
