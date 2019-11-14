using System;

//Лаб7 Задание 17
namespace L7T2
{
    class Program
    {
        static void Input(ref int[] A)
        {
            for (int i = 0; i <= A.GetUpperBound(0); i++)
            {
                
                    A[i] = int.Parse(Console.ReadLine());
                
            }
        }
        static void ChangeTheSimpleNum( ref int[] B, int i)
        {
            if (IsSimple(B[i])) B[i] = 0;
        }

        private static bool IsSimple(int v)
        {
            if (v == 1) return false;
            bool simp = true;
            for (int i = 2; i <= Math.Sqrt(v); i++)
            {
                if (v % i == 0)
                {
                    simp = false;
                    break;
                }
            }
            return simp;
        }

        static void Output(int[] B)
        {
            foreach (int el in B) Console.Write(el + " ");
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n = ");
           
            n = int.Parse(Console.ReadLine());
            
            int[] X = new int[n];
            Console.WriteLine("Введите числа построчно:");
            Input(ref X);
            for(int i = 0; i < X.Length; i++)
            ChangeTheSimpleNum(ref X, i);
            Console.WriteLine("Final:");
            Output(X);
            Console.ReadKey();
        }
    }
}
