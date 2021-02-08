using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ4
{
    static void Main()
    {
        int number;
        number = Int32.Parse(Interaction.InputBox("Введите число"));

        if (number > 5 && number <= 10) MessageBox.Show("Число попадает в диапазон");
        else MessageBox.Show("Число не попадает в диапазон");

    }
}