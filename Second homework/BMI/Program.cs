using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void bmiCalc(double height, double weight)
        {
            double idealWeight = height - 100;
            height /= 100;
            double BMI = weight / Math.Pow(height, 2);
            if (BMI > 25)
            {
                Console.WriteLine($"You have to lose {weight - idealWeight} kilos");
            }
            if(BMI == 18.5 | BMI <= 24.99)
            {
                Console.WriteLine($"Everything is okay, your BMI is {BMI:N2}");
            }
            else
            {
                Console.WriteLine($"You have to gain your weight. Remains {idealWeight - weight} kilos");
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Artyom Khairulin, KZ";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Write your height");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write your weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            bmiCalc(height, weight);
            Console.ReadKey();

        }
    }
}
