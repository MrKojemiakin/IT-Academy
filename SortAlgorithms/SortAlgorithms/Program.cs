using System;

namespace SortAlgorithms
{
    internal class ListSorting
    {
        var rnd = new Random();
        var array = new double[(int)1e6];
            for (int i = 0; i<array.Length; i++)
        {
            array[i] = rnd.NextDouble()* 100;
        }

}
    
}
