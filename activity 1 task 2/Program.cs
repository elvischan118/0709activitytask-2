using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10]; // Create an array and save 10 numbers
            int evenCount = 0; //count user input how many even number
            int oddCount = 0; //count user input how many odd number

            Console.WriteLine("Enter 10 numbers:"); //Ask user to enter 10 numbers

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--; // Decrement the loop counter to re-enter the current number
                }
            }

            Console.WriteLine($"You entered {evenCount} even numbers and {oddCount} odd numbers.");

            Console.ReadKey();
        }
    }
}
