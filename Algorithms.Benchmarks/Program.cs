using Algorithms.Core.Sorting;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algorithms.Benchmarks
{
    [MemoryDiagnoser]
    public class QuickSortBenchmarks
    {
        private int[] data;

        [GlobalSetup]
        public void Setup()
        {
            data = new int[1000];
        }

        [Benchmark]
        public void SortBenchmark()
        {
            var array = (int[])data.Clone();
            QuickSort.Sort(array);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<QuickSortBenchmarks>();
        }
    }
}
