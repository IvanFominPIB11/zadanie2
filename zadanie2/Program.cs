using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace zadanie2
{
    internal class Program
    {
        static void Main()
        {
            string res, txt, name;
            int year = 2023, age, born;
            name = Interaction.InputBox("Как Вас зовут?", "Имя");
            res = Interaction.InputBox("В каком году Вы родились?", "Год рождения");
            born= Int32.Parse(res);
            age = year - born;
            txt = "Вас зовут " + name + " и Вам" +age+ " лет";
            MessageBox.Show(txt, "Имя и возраст");
        }
    }
}
