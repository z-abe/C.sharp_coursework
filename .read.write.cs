using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Output
{
    class Project
    {
        static void Main()
        {

            int r1 = 0;
            int r2 = 0;

            Console.WriteLine("Please select values (0-5) for r1 and r2 to receive a message!");
            Console.WriteLine($"The starting value for r1 is: {r1}");
            Console.WriteLine($"The starting value for r2 is: {r2}");

            Console.Write("Please input value for r1: ");
            r1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input value for r2: ");
            r2 = Convert.ToInt32(Console.ReadLine());

            switch (r1)
            {
                case 0:
                    Console.WriteLine("Hello World!");
                    break;
                case 1:
                    Console.WriteLine("Welcome to CIT165!");
                    break;
                case 2:
                    Console.WriteLine("How are you today?");
                    break;
                case 3:
                    Console.WriteLine("Do you like cheese?");
                    break;
                case 4:
                    Console.WriteLine("Drop and give me 20 soldier!");
                    break;
                case 5:
                    Console.WriteLine("Is C sharp enough to operate on a grape?");
                    break;
                default:
                    Console.WriteLine("You did not input a value between 0 and 5, please rerun...");
                    break;
            }

            switch (r2)
            {
                case 0:
                    Console.WriteLine("Hello World!");
                    break;
                case 1:
                    Console.WriteLine("Welcome to CIT165!");
                    break;
                case 2:
                    Console.WriteLine("How are you today?");
                    break;
                case 3:
                    Console.WriteLine("Do you like cheese?");
                    break;
                case 4:
                    Console.WriteLine("Drop and give me 20 soldier!");
                    break;
                case 5:
                    Console.WriteLine("Is C sharp enough to operate on a grape?");
                    break;
                default: Console.WriteLine("You did not input a value between 0 and 5, please rerun...");
                    break;
            }

        }
    }
}
