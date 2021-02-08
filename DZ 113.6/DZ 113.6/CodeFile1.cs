using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ113
{
    // Напишите программу  которая проверяет вторую справа цифру в восьмеричном представлении числа, чисто вводится в десятичном... 
    static void Main()
    {
        int number;
        number = Int32.Parse(Interaction.InputBox("Введите число", "второе в восьмиричном"));
        
        
        int result = (number & 56) >> 3;


        // int thoundred = a / 10 % 10;
        string txt;
        txt = "Второе число в восьмиричной системе " + result + "";
        MessageBox.Show(txt);

    }
}
