using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ3
{
    static void Main ()
    {
        string dd, mesyac, god;

        /*
        Console.WriteLine ("Введите дату:");
        dd = Console.ReadLine();

        Console.WriteLine("Введите месяц:");
        mm = Console.ReadLine();

        Console.WriteLine("Введите год:");
        gg = Console.ReadLine();

        Console.WriteLine("Вы ввели {0} {1} {2}", dd, mm, gg);

        Console.ReadKey();
        */

        dd = Interaction.InputBox("Введите дату:");
        mesyac = Interaction.InputBox("Введите месяц:");
        god = Interaction.InputBox("Введите год:");

        MessageBox.Show("Вы ввели "+ dd + mesyac + god);
    }
}