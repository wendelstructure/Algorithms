using System;
using System.Collections.Generic;

namespace InsertionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sequence = new[] {3, 2, 1, 4, 5};
            Console.WriteLine($"Input:  {string.Join(",", sequence)}");

            Run(sequence);
            Console.WriteLine($"Result:  {string.Join(",", sequence)}");

            Console.ReadLine();
        }

        public static void Run(int[] sequence)
        {
            for (var index = 1; index < sequence.Length; index++)
            {
                var swapIndex = index;

                while (swapIndex > 0 && sequence[swapIndex] < sequence[swapIndex - 1])
                {
                    var key = sequence[swapIndex];
                    sequence[swapIndex] = sequence[swapIndex - 1];
                    sequence[swapIndex - 1] = key;
                    swapIndex = swapIndex - 1;
                }
            }
        }
    }
}