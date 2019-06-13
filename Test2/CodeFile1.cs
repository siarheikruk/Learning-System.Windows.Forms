using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Test2
{
    class EnteringInteger
    {
        static void Main()
        {
            string res, txt;

            int year = 2019, age, born;

            res = Interaction.InputBox("В каком году Вы родились?", "Год рождения");

            born = int.Parse(res);

            age = year - born;

            txt = "Тогда Вам " + age + " лет";

            MessageBox.Show(txt, "Возраст");

        }
    }
}