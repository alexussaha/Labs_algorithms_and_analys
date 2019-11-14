using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
       static void Swap(ref int i, ref int j)
        {
            int t = i;
            i = j;
            j = t;
        }
        static void QuickSort(int[] a, int first, int last)
        {

            if (first >= last)
            {
                return;
            }
            int x = a[(first + last) / 2];
            int i = first;
            int j = last;
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {

                    Swap(ref a[i],ref a[j]);
                    i++;
                    j--;
                }
            }

            if (i < last)
                QuickSort(a, i, last);

            if (first < j)
                QuickSort(a, first, j);
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 5, 1, 3, 5, 7, 4, 2, 1, 4 };
            QuickSort(a, 0, a.Length-1);
        }
    }
}
