using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;


class DZdemo
{
    static void Main()
    {
        //Последовательный ввод двух чисел. Программа определяет какое из чисел больше или они равны и выводит сообщение в окне

        MessageBox.Show("Выполняется программа", "Начало");
        int numberA, numberB, numberprot;
        
        try
        {
            numberA = Int32.Parse(Interaction.InputBox("Введите число A", "Сравнение А и В"));
            numberB = Int32.Parse(Interaction.InputBox("Введите число B", "Сравнение А и В"));
            
            if (numberA>numberB)
            {
                MessageBox.Show("A > В");
            } 
            else if (numberA == numberB)
            {
                MessageBox.Show("A = B");
            }
            else
            {
                MessageBox.Show("A < B");
            }
        }

        catch
        {
            MessageBox.Show("Вы ввели не число");
        }


        MessageBox.Show("Программа завершена", "Конец");
    }
}