using System;
using System.Linq;

namespace TheSieveOfEratosthenes
{
    /// <summary>
    /// Generates a list of prime numbers.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an input value:  ");
            var input = Convert.ToInt32(Console.ReadLine());
            var values = Enumerable.Range(2, input - 1).ToList();

            Console.WriteLine($"Input:  {string.Join(',', values)}");

            for (var i = 0; i < values.Count; i++)
                for (var j = i + 1; j < values.Count; j++)
                    if (values[j] % values[i] == 0)
                        values.Remove(values[j]);

            Console.WriteLine($"Result:  {string.Join(',', values)}");

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
