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
            var array = new double[(int)1e3];
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = Math.Round(rnd.NextDouble() * 100,2);
                Console.Write($"  {array[i]}");
            }

            var bubbleSort = new BubbleSort<double>(array);
            var ellapsed= bubbleSort.Sort();
            Console.WriteLine( );
            foreach (var sortItem in bubbleSort.Items)
            {
                Console.WriteLine($"  {sortItem}");
                
            }
            Console.WriteLine(ellapsed.Milliseconds);

            var quickSort = new QuickSort<double>(array);
            ellapsed = quickSort.Sort();
            Console.WriteLine();
            foreach (var sortItem in quickSort.Items)
            {
                Console.WriteLine($"  {sortItem}");

            }
            Console.WriteLine(ellapsed.Milliseconds);

        }

        
        
    }
}
