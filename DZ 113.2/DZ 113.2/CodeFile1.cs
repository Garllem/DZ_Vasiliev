using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ1
{
    static void Main()
    {
        int number, numberfive, numberSeven;

        number = Int32.Parse(Interaction.InputBox("введите число", "Проверка на условия при делении на 5 в остатке 2, при делении на 7 в остатке 1"));

        numberfive = number % 5;
        numberSeven = number % 7;
        string txt = "Число ";
        txt += (numberfive == 2 & numberSeven == 1 ? "делится на 5 и 7" : "не делится на 5 и 7");
        MessageBox.Show(txt);
    }
}