using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ18
{
    static void Main ()
    {
        string one, thu;
        int A, B, C;

        /*
        Console.WriteLine("введите A");
        one = Console.ReadLine();
        A = System.Int32.Parse(one);

        Console.WriteLine("введите B");
        thu = Console.ReadLine();
        B = System.Int32.Parse(thu);

        C = A + B;

        Console.WriteLine("Сумма А и В = " + C);
        Console.ReadKey();
        */
        one = Interaction.InputBox("Введите А");
        A = System.Int32.Parse(one);

        thu = Interaction.InputBox("Введите В");
        B = System.Int32.Parse(thu);

        C = A + B;

        MessageBox.Show("Сумма А и В =" + C);


    }
}