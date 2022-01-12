using Algorithm;
using System;
using System.Threading.Channels;


namespace SortAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var array = new double[(int) 1e3];
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = Math.Round(rnd.NextDouble() * 100, 2);
                Console.Write($"  {array[i]}");
            }
            DoSort(new BubbleSort<double>(array));
            
            DoSort(new QuickSort<double>(array));

            


        }

        private static void DoSort(AlgorithmBase<double> sorter)
        {
            //var quickSort = new QuickSort<double>(array);
            var ellapsed = sorter.Sort();
            Console.WriteLine();
            foreach (var sortItem in sorter.Items)
            {
                Console.WriteLine($"  {sortItem}");

            }

            Console.WriteLine(ellapsed.Milliseconds);
        }



    }
}
