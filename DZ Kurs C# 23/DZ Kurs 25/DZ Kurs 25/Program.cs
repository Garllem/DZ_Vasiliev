using System;

namespace DZ_Kurs_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию");
            string Fam = Console.ReadLine();

            Console.WriteLine("Введите Имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Возраст");
            string old = Console.ReadLine();

            Console.WriteLine("Введите Рост");
            double rost = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Вес");
            double Ves = double.Parse(Console.ReadLine());

            double IMT = Ves / (rost/100*rost/100);

            Console.WriteLine($"{Fam} {name}");
            Console.WriteLine($"Age:{old}");
            Console.WriteLine($"Weight:{Ves}");
            Console.WriteLine($"Height:{rost}");
            Console.WriteLine($"Body Mass Index:{IMT}");

        }
    }
}
