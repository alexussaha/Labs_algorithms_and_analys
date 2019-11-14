using System;
// Задание 8 из лаб1

namespace Laba
{
    class Program
    {
        static void IfOddWeAddAndCount(int[] a, out int[] b, ref int counter)
        {
            b = new int[0];
            int len = 0;
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] % 2 != 0) { Array.Resize<int>(ref b, len + 1); b[len] = a[i]; counter++; len++;   }
            }
        }
        
        static void Main(string[] args)
        {
            int[] basic = { 1, 2, 4, 5, 3, 234, 34 };
            int[] final;
            int counter = 0;
            IfOddWeAddAndCount(basic, out final, ref counter);
            foreach (int a in final) Console.Write(a + " ");
            Console.WriteLine();
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
