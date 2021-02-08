using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ
{
    static void Main()
    {
        string name, familia, txt;

        /* name = Interaction.InputBox("введите Ваше имя: ");

        familia = Interaction.InputBox("введите Вашe фамилию: ");

        MessageBox.Show(name + " " + familia, "Ваше имя и фамилия");
        */

        Console.WriteLine ("Введите имя");
        name = Console.ReadLine();

        Console.WriteLine ("Введите фамилию");
        familia = Console.ReadLine();

        txt = name + " " + familia;
        Console.WriteLine(txt);

        Console.ReadKey();

    }
}