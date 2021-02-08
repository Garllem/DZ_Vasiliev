using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;


class DZdemo
{
    static void Main()
    {
        //Прогу ввести название дня недели. Прога выдаёт порядковый номер. Если введён неверное название - ошибка
        //Используйте switch и обработку ошибок.

        MessageBox.Show("Выполняется программа", "Погнали");
        string week;
        string txt = "Вы ввели неверный день недели";

        
        try
        {
            week = Interaction.InputBox("Введите день недели", "Понедельник - Воскресенье");


            switch (week)
            {
                case "Понедельник":
                    txt = "1";
                    break;
                case "понедельник":
                    txt = "1";
                    break;
                case "Вторник":
                    txt = "2";
                    break;
                case "Среда":
                    txt = "3";
                    break;
                case "Четверг":
                    txt = "4";
                    break;
                case "Пятница":
                    txt = "5";
                    break;
                case "Суббота":
                    txt = "6";
                    break;
                case "Воскресенье":
                    txt = "7";
                    break;

            }
            MessageBox.Show(txt, "День недели");
            
        }

        catch
        {
            MessageBox.Show("Вы ввели неправильный день недели");
        }


        MessageBox.Show("Программа завершена", "Конец");
    }
}