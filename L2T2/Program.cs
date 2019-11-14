using System;

//Лаб2 Задание 32

namespace L2T2
{
    class Program
    {


        static int AmountOfSortedStrings(ref int[,] a)
        {
            int counter = 0;
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j < a.GetUpperBound(1); j++)
                {
                    if (a[i, j] > a[i, j + 1]) break;
                    if (j == a.GetUpperBound(1) - 1) counter++;
                }
               
            }
            return counter;
        }
                
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 6, 5, 6, 4 }, { 9, 8, 9, 10 }, { 10, 11, 12,12 } };
            int c = AmountOfSortedStrings(ref matrix);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
