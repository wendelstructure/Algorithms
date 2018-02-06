using System;

namespace SelectionSort
{
    public class Program
    {
        // Time Complexity:  O(n^2)
        public static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort (Default)");
            Default.Run();

            Console.WriteLine("\nSelection Sort (In-Place)");
            InPlace.Run();

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
