using System;

namespace DZ_Kurs_C_3._11
{
    class Program
    {
        static int[] fibs (int n)
        {
           
            int [] fibonachi = new int[n];

            fibonachi[0] = 1;

            if (fibonachi.Length == 1) return fibonachi;

            fibonachi[1] = 1;
            for (int i=2;i<fibonachi.Length;i++)
            {
                fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
            }
            return fibonachi;
        }
        static void Main ()
        {
            int[] A;
            int kol = 0;
            Console.WriteLine("Введите количество чисел фибоначи:");
            kol = int.Parse(Console.ReadLine());
            Console.WriteLine("Числа фибоначи:");
            A = fibs(kol);
            foreach (int s in A)
            {
                Console.Write("| {0}", s);
            }

        }
    }
}
