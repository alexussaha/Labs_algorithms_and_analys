using System;
using System.Collections.Generic;


//Лаб. 2 задание 7

namespace L2T1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12} };
            List<int> answer = new List<int>();
            int sum = 0;
            for(int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    if (matrix[i, j] % 2 != 0) sum += matrix[i, j];
                }
                answer.Add(sum);
                sum = 0;
            }
            foreach (int el in answer) Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
