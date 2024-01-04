using POO1.Exercises.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1.Exercises.Exercises
{
    internal class Exercise01 : Exercise
    {
        public override void Execute()
        {
            int selected;
            string[] options = { "Celsius para Fahrenheit", "Fahrenheit para Celsius" };
            selected = Menu.DisplayMenu(options);
            Console.WriteLine(selected);
        }
    }
}
