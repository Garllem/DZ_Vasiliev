using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ113
{
    // Напишите программу  которая проверяет сколько тысяч во введённом пользователе числе 
   static void Main ()
    {
        int number, thoundred;
        number = Int32.Parse(Interaction.InputBox("Введите число", "Сколько тысяч"));

        thoundred = number / 1000 % 10;
        string txt;
        txt = "В числе " + thoundred + " тысяч";
        MessageBox.Show(txt);

    }
}
