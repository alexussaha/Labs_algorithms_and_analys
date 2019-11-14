using System;

//Лаб3 Задание 28

namespace L3T2
{
    class MyArray
    {
        int[,] A;
        public MyArray(int i, int j)
        {
            A = new int[i, j];
        }
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

                    Swap(ref a[i], ref a[j]);
                    i++;
                    j--;
                }
            }

            if (i < last)
                QuickSort(a, i, last);

            if (first < j)
                QuickSort(a, first, j);
        }

        public int SimularWithTheFirst()
        {
           int p = 0;
            int count = 0;
            int totalCount = 0;
            int[] temp0 = new int[A.GetUpperBound(1) + 1];
            int[] temp = new int[A.GetUpperBound(1) + 1];

            for (int i = 0; i <= A.GetUpperBound(1); i++)
            {
                temp0[i] = A[0, i];
            }
            QuickSort(temp0, 0, temp0.Length - 1);
            for (int q = 1; q < A.GetUpperBound(0); q++)
            {

                for (int i = 0; i <= A.GetUpperBound(1); i++)
                {
                    temp[i] = A[q,i];
                }
                QuickSort(temp, 0, temp.Length - 1);
                for (int j = 0; j <= A.GetUpperBound(1); j++)
                {
                    if (temp[j] == temp0[j]) count++;
                }
                if (count == temp.Length) totalCount++;

            }
            return totalCount;
        }
        public void Input()
        {
            int a;
            for (int i = 0; i <= A.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= A.GetUpperBound(1); j++)
                {
                    a =  int.Parse(Console.ReadLine());
                    if (a > 0 && a < 100)
                        A[i, j] = a;
                    else
                    {
                        j--;
                        Console.WriteLine("Введите значение от 1 до 100");
                    }
                }
            }
        }
        public void Output()
        {
            for (int i = 0; i <= A.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= A.GetUpperBound(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            Console.WriteLine("Введите M:");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите N:");
            N = int.Parse(Console.ReadLine());
            MyArray a = new MyArray(M, N);
            Console.WriteLine("Введите значения построчно:");
            a.Input();
            a.Output();
            
            int b = a.SimularWithTheFirst();
            Console.WriteLine($"Колличество похожих строк = {b}");
            a.Output();
            Console.ReadKey();
        }
    }
}
