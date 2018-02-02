using System;

namespace FermatsLittleTheorem
{
    /// <summary>
    /// Determines whether a number is prime.
    /// Pick a random value between 1 and the input.  I've chosen 2.
    /// If the random value raised to the power of the input minus 1
    /// is equal to one then the input is a prime number. 
    /// The input must be greater than 2.
    /// The number to raise to the power of input - 1 must be less than input.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an input:  ");
            var input = Convert.ToDouble(Console.ReadLine());
            var result = input == 2;

            if (result)
            {
                Console.WriteLine("2 is a prime number.");
                Console.Write("Press any key to exit...");
                Console.ReadKey();
            }

            for (var i = 2; i < input; i++)
            {
                result = Math.Pow(2, input - 1) % input == 1;

                if (!result)
                    break;
            }

            Console.WriteLine(result 
                ? $"{input} is a prime number." 
                : $"{input} is not a prime number.");

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
