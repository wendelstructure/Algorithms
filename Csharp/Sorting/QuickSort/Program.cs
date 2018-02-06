using System;
using System.Collections.Concurrent;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.CompilerServices;

namespace QuickSort
{
    /// <summary>
    /// Time Complexity:  O(n log n).
    /// Uses a divide an conqure strategy.
    /// Not good for collections with lots of duplicates.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var values = "4 5 1 2 8 4 7 5 9 1 6 7 3 4 9 2 5 6 6 7 4 5";
            var array = CreateSequence(values);

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine($"Input:  {values}");
            Console.WriteLine($"Result:  {string.Join(' ', array)}");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }

        private static int[] CreateSequence(string sequence)
        {
            return sequence.Split()
                .Select(m => Convert.ToInt32(m))
                .ToArray();
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            var pivotValue = array[(left + right) / 2];
            var pivotIndex = Partition(array, left, right, pivotValue);

            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex, right);
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                    left++;

                while (array[right] > pivot)
                    right--;

                if (left > right)
                    continue;

                var temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }

            return left;
        }
    }
}
