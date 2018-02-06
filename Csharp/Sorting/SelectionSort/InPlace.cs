using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectionSort
{
    public class InPlace
    {
        public static void Run()
        {
            var inputSequence = "7 5 8 3 2 1";

            var sequence = inputSequence.Split()
                .Select(m => Convert.ToInt32(m))
                .ToList();

            for (var i = 0; i < sequence.Count; i++)
            {
                var lowest = sequence[i];
                var lowestIndex = i;

                for (var j = i + 1; j < sequence.Count; j++)
                    if (lowest > sequence[j])
                    {
                        lowest = sequence[j];
                        lowestIndex = j;
                    }

                var temp = sequence[i];
                sequence[i] = lowest;
                sequence[lowestIndex] = temp;
            }

            Console.WriteLine($"Input:  {inputSequence}");
            Console.WriteLine($"Result:  {string.Join(' ', sequence)}");
        }
    }
}
