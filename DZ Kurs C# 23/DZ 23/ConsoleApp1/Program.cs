using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону A");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону B");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону C");
            double C = double.Parse(Console.ReadLine());

            double P = (A + B + C) / 2;

            double S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            Console.WriteLine($"Площадь треугольника равна {S}");

        }
    }
}
