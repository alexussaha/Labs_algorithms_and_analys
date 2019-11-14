using System;


//Задание 33 из лаб. 1

namespace lab1Task2
{
    class Program
    {

       static int LocalMin(ref int[] a) {
            if (a.Length == 1) return a[0];
            if (a[0] < a[1]) return a[0];
            for(int i = 1; i < a.Length - 1; i++)
            {
                if(a[i] < a[i+1] && a[i] < a[i + 1])
                {
                    return a[i];
                }
            }
            return a[a.Length];
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 4, 2, 3, 23, 1, 22, 42, 54, 54 };
            int localMin = LocalMin(ref a);
            Console.WriteLine(localMin);
            Console.ReadKey();
        }
    }
}
