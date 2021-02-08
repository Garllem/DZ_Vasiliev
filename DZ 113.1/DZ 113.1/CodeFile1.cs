using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ1
{
    static void Main ()
    {
        int number, numberTree;

        number = Int32.Parse(Interaction.InputBox("введите число", "Проверка деления на 3"));

        numberTree = number % 3;
        string txt = "Число ";
        txt+=(numberTree==0?"делится на 3":"не делится на 3");
        MessageBox.Show(txt);
    }
}