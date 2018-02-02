using System;

namespace FermatsLittleTheorem
{
    /// <summary>
    /// Determines whether a number is prime.
    /// Pick a random value between 1 and the input.  I've chosen 2.
    /// If the random value raised to the power of the input minus 1
    /// is equal to one then the input is a prime number. 
    /// The input must be greater than 2.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an input:  ");
            var input = Convert.ToDouble(Console.ReadLine());
            var result = input <= 2
                ? true
                : Math.Pow(2, input - 1) % input == 1;

            Console.WriteLine(result 
                ? $"{input} is a prime number." 
                : $"{input} is not a prime number.");

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
