using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;


class DZdemo
{
    static void Main()
    {
        //Прога в которой вводится число от 1 до 7. Прога определяет день недели. Используйте switch и обработку ошибок.

        MessageBox.Show("Выполняется программа", "Погнали");
        int numberA, numberB, numberC = 0;
        string txt = "Вы ввели число за пределами 1 и 7";

        try
        {
            numberA = Int32.Parse(Interaction.InputBox("Введите число", "От 1 до 7"));
            
           // if (numberA>=1 & numberA<=7) {
                switch (numberA)
                {
                    case 1:
                        txt = "Понедельник";
                        break;
                    case 2:
                        txt = "Вторник";
                        break;
                    case 3:
                        txt = "Среда";
                        break;
                    case 4:
                        txt = "Четверг";
                        break;
                    case 5:
                        txt = "Пятница";
                        break;
                    case 6:
                        txt = "Суббота";
                        break;
                    case 7:
                        txt = "Воскресенье";
                        break;

                }
                MessageBox.Show(txt,"День недели");
            //}
        }

        catch
        {
            MessageBox.Show("Вы ввели не число");
        }


        MessageBox.Show("Программа завершена", "Конец");
    }
}