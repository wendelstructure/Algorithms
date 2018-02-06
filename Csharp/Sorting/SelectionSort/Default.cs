using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectionSort
{
    public class Default
    {
        public static void Run()
        {
            var input = "7 5 8 3 2 1";

            var sequence = input.Split()
                .Select(m => Convert.ToInt32(m))
                .ToList();

            var sortedSequence = new List<int>();

            var i = 0;

            while(sequence.Any())
            {
                var lowest = sequence[i];
                var lowestIndex = i;
                
                for (var j = i + 1; j < sequence.Count; j++)
                    if (lowest > sequence[j])
                    {
                        lowest = sequence[j];
                        lowestIndex = j;
                    }
                
                i = 0;
                sequence.RemoveAt(lowestIndex);
                sortedSequence.Add(lowest);
            }

            Console.WriteLine($"Result:  {input}");
            Console.WriteLine($"Result:  {string.Join(',', sortedSequence)}");
        }
    }
}
