﻿using System;

//Лаб5 Задание 45

namespace L5T2
{
    class MyArray
    {
        int[] A;
        public MyArray(int k)
        {
            A = new int[k] ;
        }
        public void ShowTheClosestElements()
        {
            double min = double.PositiveInfinity;
            double isClose;
            int indx1 = -1, indx2 = -1;
            for (int i = 1; i < A.Length; i++)
            {
                isClose = Math.Abs(A[i - 1]-A[i]);
                if (isClose < min)
                {
                    min = isClose;
                    indx1 = i - 1;
                    indx2 = i;
                }
            }
            Console.WriteLine($"Индекс первого элемента: {indx1}; индекс второго элемента: {indx2} ");
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
            a.ShowTheClosestElements();
            Console.ReadKey();
        }
    }
}
