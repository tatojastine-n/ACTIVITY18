using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            while (true)
            {
                Console.Write("Enter a positive integer: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out number) || number <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    continue;
                }
                break;
            }
            Console.WriteLine($"\nCountdown from {number}:");

            int current = number;
            while (current >= 0)
            {
                Console.WriteLine(current);
                current--;
            }
            Console.WriteLine("\nLiftoff!");
        }
    }
}
