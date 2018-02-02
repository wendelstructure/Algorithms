using System;
using System.Collections.Generic;

namespace Primefactorization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a value to factorize:  ");

            var num = Convert.ToInt64(Console.ReadLine());
            var factor = 3;
            var factors = new List<long>();

            while (factor < Math.Sqrt(num))
            {
                Console.WriteLine(factor);
                while (num % factor == 0)
                {
                    factors.Add(factor);
                    num = num / factor;
                }

                if (factor * factor > num)
                {
                    factors.Add(num);
                    return;
                }

                factor += 2;
            }
            
            Console.WriteLine($"Result:  {string.Join('*', factors)}");

            Console.Write("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
