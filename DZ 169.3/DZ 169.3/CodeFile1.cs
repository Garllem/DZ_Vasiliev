using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;


class DZdemo
{
    static void Main()
    {
        //Прога в которой вычисляется сумма чисел, которые вводит пользователь. Вывоз запроса на ввод числа, считывает, прибавляет к сумме
        // и снова запрашивает. Процесс продолжается пока пользователь не введёт нулевое значение.

        MessageBox.Show("Выполняется программа", "Начало");
        int numberA, numberB, numberC = 0;

        try
        {
            
            do {
                numberA = Int32.Parse(Interaction.InputBox("Введите число", "Суммируем введёные числа"));
                numberB = numberA + numberC;
                string msg = Convert.ToString(numberB);

                MessageBox.Show(msg);

                numberC = numberB;

                } while (numberA != 0) ;
        }

        catch
        {
            MessageBox.Show("Вы ввели не число");
        }


        MessageBox.Show("Программа завершена", "Конец");
    }
}