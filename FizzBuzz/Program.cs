using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print numbers from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                // Multiples of 3 & 5 - FizzBuzz
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                // Multiples of 3 - Fizz
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                // Multiples of 5 - Buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
