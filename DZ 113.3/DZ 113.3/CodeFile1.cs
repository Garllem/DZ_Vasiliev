using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ1
{
    static void Main()
    {
        int number, numberfive;

        number = Int32.Parse(Interaction.InputBox("Введите число", "Проверка на условия деления на 4 и >10"));

        numberfive = number % 4;
        
        string txt = "Число ";
        txt += (numberfive == 0 & number >= 10 ? "делится на 4 и >=10" : " НЕ делится на 4 и >=10");
        MessageBox.Show(txt);
    }
}