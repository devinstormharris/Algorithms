using Algorithms.Core.Sorting;

namespace Algorithms.Samples
{
    class Program
    {
        static void Main()
        {
            int[] arrayToSort = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };

            DisplayArray("Unsorted Array:", arrayToSort);

            QuickSort.Sort(arrayToSort);

            DisplayArray("Sorted Array:", arrayToSort);
        }

        static void DisplayArray(string label, int[] array)
        {
            Console.WriteLine($"{label} {string.Join(", ", array)}");
        }
    }
}
