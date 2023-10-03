namespace Algorithms.Core.Sorting
{
    /// <summary>
    /// Provides methods for performing the QuickSort algorithm.
    /// </summary>
    public static class QuickSort
    {
        /// <summary>
        /// Sorts an array using the QuickSort algorithm.
        /// </summary>
        /// <typeparam name="T">Type of the array elements, which must be comparable.</typeparam>
        /// <param name="array">The array to be sorted.</param>
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);
                Sort(array, low, pivot - 1);
                Sort(array, pivot + 1, high);
            }
        }

        private static int Partition<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            T pivot = array[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }
            Swap(ref array[i + 1], ref array[high]);
            return i + 1;
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
    }
}
