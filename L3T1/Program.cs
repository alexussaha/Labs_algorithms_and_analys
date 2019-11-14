using System;

//Лаб3 Задание 3

namespace L3T1
{
    class MyArray
    {
        int[,] A;
        public MyArray(int i, int j)
        {
            A = new int[i, j];
        }
        public void ChangeTheRows(int p, int q)
        {
            p = p - 1;
            q = q - 1;

            int temp;
            for (int i = 0; i <= A.GetUpperBound(1); i++)
            {
                temp = A[p, i];
                A[p, i] = A[q, i];
                A[q, i] = temp;
            }

        }
        public void Input()
        {
            for (int i = 0; i <= A.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= A.GetUpperBound(1); j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
       public void Output()
        {
            for (int i = 0; i <= A.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= A.GetUpperBound(1); j++)
                {
                    Console.Write(A[i,j] + " ");
                }
                Console.WriteLine();
            }
          
           
        }
            
          
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int M, N, P, Q;
            Console.WriteLine("Введите M:");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите N:");
            N = int.Parse(Console.ReadLine());
            MyArray a = new MyArray(M,N);
            Console.WriteLine("Введите значения построчно:");
            a.Input();
            a.Output();
            Console.WriteLine("Введите P :");
            P = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Q:");
            Q = int.Parse(Console.ReadLine());
            a.ChangeTheRows(P, Q);
            Console.WriteLine();
            a.Output();
            Console.ReadKey();


        }
    }
}
