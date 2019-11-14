using System;

//Лаб6 Задание 20

namespace L6T1
{
    class MyArray
    {
        int[] A;
        public MyArray(int k)
        {
            A = new int[k];
        }
        public void GeometricalProgress()
        {

            int q = A[1] / A[0];
            for (int i = 2; i < A.Length; i++)
            {
                if(A[i]/A[i-1] != q)
                {
                    Console.WriteLine($"q = 0");
                    return;
                }
                
            }
            Console.WriteLine($"q = {q}");
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
            a.GeometricalProgress();
            Console.ReadKey();
        }
    }
}
