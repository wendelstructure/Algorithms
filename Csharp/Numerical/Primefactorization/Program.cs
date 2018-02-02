using System;
using System.Collections.Generic;

namespace Primefactorization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a value to factorize:  ");

            var number = Convert.ToInt64(Console.ReadLine());
            var factors = new List<long>();

            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }

            var factor = 3;

            while (factor * factor <= number)
            {
                if (number % factor != 0)
                {
                    factor += 2;
                    continue;
                }

                factors.Add(factor);
                number = number / factor;
            }

            //number will now equal to the final prime factor as the square
            //of the current factor is greater than number.  So we add the
            //number to the list of factors.
            factors.Add(number);

            Console.WriteLine($"Result:  {string.Join('*', factors)}");

            Console.Write("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
