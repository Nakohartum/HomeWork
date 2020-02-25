using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingForPassword
{
    class Program
    {
        static void checking()
        {
            int i = 0;
            string login = "root";
            string password = "GeekBrains";
            do
            {
                Console.WriteLine("Write your login and password");
                string userLogin = Console.ReadLine();
                string userPass = Console.ReadLine();
                if (login == userLogin && password == userPass)
                {
                    Console.WriteLine("All is correct!");
                    break;
                }
                else
                {
                    if (3 - i != 0)
                    {
                        i++;
                        Console.WriteLine($"Try again. Tries left {3 - i}");
                    }
                    if (3 - i == 0) 
                    {
                        Console.WriteLine("Sorry, you are out of attempts");
                    }
                    
                    
                }
            }
            
            while (i != 3);
        }
        static void Main(string[] args)
        {
            Console.Title = "Artyom Khairulin, KZ";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            checking();
            Console.ReadKey();
        }
    }
}
