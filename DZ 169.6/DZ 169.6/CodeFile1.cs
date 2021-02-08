using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;


class DZdemo
{
    static void Main()
    {
        //Прогу в которой вычисляется сумма нечетных чисел. Разные операторы цикла

        MessageBox.Show("Выполняется программа", "Погнали");
        int numberA, numberB, n = 0;
        
        try
        {
            numberA = Int32.Parse(Interaction.InputBox("Введите нечётное число A", "Сумма нечётных чисел"));
            numberB = Int32.Parse(Interaction.InputBox("Введите нечётное число B", "Сумма нечётных чисел"));

            int s = numberA;
            while (s <= numberB)
            {
                s += 2;
                    //n++;

            }
            int p = s + numberB;

            string txt = p.ToString();
            
            MessageBox.Show(txt, "День недели");

        }

        catch
        {
            MessageBox.Show("Вы ввели не числа");
        }


        MessageBox.Show("Программа завершена", "Конец");
    }
}
