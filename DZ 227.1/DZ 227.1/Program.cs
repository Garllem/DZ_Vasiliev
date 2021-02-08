using System;

namespace DZ_227._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа выполняется");
            int a = 5,s=0;
            Console.WriteLine("Введите размер одномерного числового массива");
            //a = Int32.Parse(Console.ReadLine());
            int[] numbs = new int[a];
            //bool b = false;
            for (int i = 0; i < numbs.Length; i++)
            {
                var isAdded = false;
                while (isAdded == false) {
                    if (s % 5 == 2) {
                        numbs[i] = s;
                        Console.Write("|" + numbs[i]);
                        isAdded = true;
                        
                    }
                    s++;
                } 
            }
            
            Console.WriteLine(" Программа завершена");
        }
    }
}
