using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ18
{
    static void Main ()
    {
        string res, txt;
        int yaer = 2019, age, born;

        /*
        res = Interaction.InputBox("Введите Ваш возраст", "ваш возраст");
        age = System.Int32.Parse(res);

        born = yaer - age;
        txt = "Вы родились в "+ born;

        MessageBox.Show(txt);
        */
        Console.WriteLine("введите ваш возраст");
        res = Console.ReadLine();
        age = System.Int32.Parse(res);
        born = yaer - age;
        txt = "Вы родились в " + born;
        Console.WriteLine(txt);

        Console.ReadKey();

    }
}