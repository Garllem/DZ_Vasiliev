using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;


class DZdemo
{
    static void Main ()
    {
        MessageBox.Show("Выполняется программа", "Начало");
        int number, numberPro, numberprot;
        

        try
        {
            number = Int32.Parse(Interaction.InputBox("введите число", "Проверка деления на 3 и на 7"));
            numberPro = number % 3;
            numberprot = number % 7;

            if ((number % 3 == 0) && (number % 7 == 0))
            {
                MessageBox.Show("Число делится на 3 и на 7");

            } else {
                MessageBox.Show("Число не делится на 3 и на 7");
            }
        }

        catch
        {
            MessageBox.Show("Вы ввели не число");
        }


        MessageBox.Show("Программа завершена", "Конец");
    }
}