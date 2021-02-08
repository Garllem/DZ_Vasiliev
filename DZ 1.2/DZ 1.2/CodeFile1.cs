using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

    class DZ1
{
    static void Main ()
    {
        string name, age;
        int borne;

        /*
        Console.WriteLine("Введите ваше имя:");
        name = Console.ReadLine();
        Console.WriteLine("Ведите Ваш возраст:");
        age = Console.ReadLine();
        borne= Int32.Parse(age);

        Console.WriteLine("Ваше имя " + name + " Ваш возраст " + age);
        Console.ReadKey();
        */
        name = Interaction.InputBox("введите ваше имя");
        age = Interaction.InputBox("Введите ваш возраст");
        borne = Int32.Parse(age);
        MessageBox.Show("Ваше имя " + name + " " + "Ваш возраст " + borne);

    }
}
