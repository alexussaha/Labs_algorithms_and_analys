using System;

//Лаб5 Задание 20

namespace L5T1
{
    class MyArray
    {
        int[] A;
        public MyArray(int N)
        {
            A = new int[N];
        }
        public void GoodNumber()
        {
            int index = 0;
            
            for (int i = 1; i < A.Length-1; i++)
            {
                if (A[i] > A[0] && A[i] < A[A.Length - 1]) index = i;
            }

            Console.WriteLine($"индекс {index}");
                
            
            
        }
        public void Input()
        {
            for (int i = 0; i < A.Length; i++)
            {

                A[i] = int.Parse(Console.ReadLine());

            }
        }
        public void Output()
        {
            for (int i = 0; i < A.Length; i++)
            {

                Console.Write(A[i] + " ");

                Console.WriteLine();
            }


        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите N:");
            N = int.Parse(Console.ReadLine());
            MyArray a = new MyArray(N);
            Console.WriteLine("Введите значения построчно:");
            a.Input();
            Console.WriteLine();
            a.GoodNumber();
            Console.ReadKey();
        }
    }
}
