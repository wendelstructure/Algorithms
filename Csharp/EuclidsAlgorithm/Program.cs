using System;

namespace EuclidsAlgorithm
{
    /// <summary>
    /// Calculate the greatest common denominator of two numbers.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var first = GetNumber("first");
            var second = GetNumber("second");

            // Divide the first number by the second number.
            // If the remainder is zero you have reached the answer.
            // If the remainder is not zero, set the second number equal
            // the remainder and set the first number equal to the second
            // number.  Repeat until the remainder is equal to zero.
            while (second != 0)
            {
                var remainder = first % second;
                first = second;
                second = remainder;
            }

            Console.WriteLine($"Result:  {first}");

            Console.Write("Press enter to exit...");
            Console.ReadLine();
        }

        public static int GetNumber(string name)
        {
            Console.Write($"Enter a value for {name}:  ");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
