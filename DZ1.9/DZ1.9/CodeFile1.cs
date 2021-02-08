using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ19
{
    static void Main()
    {
        string one;
        int A, B, C;

        /*
        Console.WriteLine("введите число");
        one = Console.ReadLine();
        A = System.Int32.Parse(one);

        B = A - 1;
        C = A + 1;

        Console.WriteLine("{0} {1} {2}", B, A, C);
        Console.ReadKey();
        */
        one = Interaction.InputBox("Введите число А");
        A = System.Int32.Parse(one);
        B = A - 1;
        C = A + 1;

        MessageBox.Show(B + " " + A + " " + C);

    }
}