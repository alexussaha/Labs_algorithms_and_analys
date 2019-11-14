using System;

//Лаб6 Задание 45
namespace L6T2
{
    class MyArray
    {
        int[] A;
        public MyArray(int k)
        {
            A = new int[k];
        }
        public void FindTheNumbersAndTheirSum(int K)
        {
            int count = 0;
            int sum = 0;
            int tmp = 0;         
            for (int i = 1; i < A.Length; i++)
            {
                if (Math.Abs(A[i] - A[i - 1]) == K)
                {
                    if (A[i - 1] == tmp)
                    {
                        count++;
                        sum += A[i];
                    }
                    else
                    {
                        count += 2;
                        sum = sum + A[i - 1] + A[i];
                    }

                    tmp = A[i];
                }

            }
            Console.WriteLine($"sum = {sum}, count = {count}");
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
            Console.WriteLine("Введите k:");
            int num = int.Parse(Console.ReadLine());
            a.FindTheNumbersAndTheirSum(num);
            Console.ReadKey();
        }
    }
}
