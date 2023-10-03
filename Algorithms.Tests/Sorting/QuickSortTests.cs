using Algorithms.Core.Sorting;

namespace Algorithms.Tests.Sorting
{
    [TestFixture]
    public class QuickSortTests
    {
        [TestCase(new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5 }, new int[] { 1, 1, 2, 3, 4, 5, 5, 6, 9 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 5, 5, 5, 5 }, new int[] { 5, 5, 5, 5 })]
        [TestCase(new int[] { -3, -1, -4 }, new int[] { -4, -3, -1 })]
        [TestCase(new int[] { -3, 1, -4, 4 }, new int[] { -4, -3, 1, 4 })]
        public void Sort_GivenIntegerArray_ReturnsSortedArray(int[] actual, int[] expected)
        {
            QuickSort.Sort(actual);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(new string[] { "cherry", "banana", "apple" }, new string[] { "apple", "banana", "cherry" })]
        [TestCase(new string[] { "apple", "Apple", "aPple" }, new string[] { "Apple", "aPple", "apple" })]
        [TestCase(new string[] { }, new string[] { })]
        public void Sort_GivenStringArray_ReturnsSortedArray(string[] actual, string[] expected)
        {
            QuickSort.Sort(actual);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
