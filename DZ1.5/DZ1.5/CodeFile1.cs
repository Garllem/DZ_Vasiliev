using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DZ15
{
    static void Main ()
    {
        string age, txt, name;
        int god = 2019, born, res;

        /* name = Interaction.InputBox("введите имя", "ваше имя");
        age = Interaction.InputBox ("введите год вашего рождения");
        res = System.Int32.Parse(age);
        born = god - res;
        
        txt = "Тогда Вам " + born + " года/лет";

        MessageBox.Show(name +" "+ txt);
        */
        Console.WriteLine("введите имя");
        name = Console.ReadLine();

        Console.WriteLine("введите год вашего рождения");
        age = Console.ReadLine();
        res = System.Int32.Parse(age);
        born = god - res;

        Console.WriteLine("Ваше имя: {0}, ваш возраст {1}", name, born);

        Console.ReadKey();
            


    }
}
