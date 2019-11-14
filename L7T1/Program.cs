using System;

//Лаб7 Задание 4
namespace L7T1
{
    class Program
    {
        static void Input(ref int[,] A)
        {
            for (int i = 0; i <= A.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= A.GetUpperBound(1); j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void DoTheLineRise(ref int[,] A, ref int[] B, int i) 
        {
            for(int j = 1; j < A.GetUpperBound(1); j++)
            {
                if(A[i,j-1]> A[i, j])
                {
                    B[i] = 0;
                    return;
                }

            }
            B[i] = 1;
        }
        static void Output(int[] B)
        {
            foreach (int el in B) Console.Write(el + " ");
        }

        static void Main(string[] args)
        {
            int M, N;
            Console.WriteLine("N = ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("M = ");
            M = int.Parse(Console.ReadLine());
            int[,] A = new int[N, M];
            int[] B = new int[N];
            Console.WriteLine("Введите числа построчно:");
            Input(ref A);
            for(int i = 0; i<=A.GetUpperBound(0); i++)
            {
                DoTheLineRise(ref A, ref B, i);
            }
            Console.WriteLine("B = ");
            Output(B);
            Console.ReadKey();
        }
    }
}
