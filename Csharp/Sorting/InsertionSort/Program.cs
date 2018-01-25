using System;
using System.Collections.Generic;

namespace InsertionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sequence = new List<int> { 5, 4, 3, 2, 1 };
            Console.WriteLine($"Input:  {string.Join(",", sequence)}");

            Run(sequence);
            Console.WriteLine($"Result:  {string.Join(",", sequence)}");

            Console.ReadLine();
        }

        public static void Run(List<int> sequence)
        {
            var n = sequence.Count;

            for (var index = 1; index < n; index++)
            {
                var swapIndex = index;

                while (swapIndex != 0 && sequence[swapIndex] < sequence[swapIndex - 1])
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