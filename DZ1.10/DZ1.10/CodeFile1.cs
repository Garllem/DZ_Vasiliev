using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ110
{
    static void Main ()
    {
        string one, two, txt, txt2;
        int A, B, C, D;

        one = Interaction.InputBox("Введите А");
        A = System.Int32.Parse(one);

        two = Interaction.InputBox("введите В");
        B = System.Int32.Parse(two);

        C = A + B;
        D = A - B;

        txt = "Сумма А и В = " + C+"     ";
        txt2 = "Разность А и В = " + D;

        MessageBox.Show(txt+txt2);
    }
}