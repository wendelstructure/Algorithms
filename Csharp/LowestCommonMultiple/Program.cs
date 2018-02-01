using System;

namespace LowestCommonMultiple
{
    /// <summary>
    /// To find the lowers common multiple of two numbers divide their product by their
    /// greatest common denominator(which can be found using Euclids Algorithm).
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var num1 = GetNumber("#1");
            var num2 = GetNumber("#2");

            var product = num1 * num2;

            while (num2 != 0)
            {
                var remainder = num1 % num2;
                num1 = num2;
                num2 = remainder;
            }

            Console.WriteLine($"Result:  {product / num1}");

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
