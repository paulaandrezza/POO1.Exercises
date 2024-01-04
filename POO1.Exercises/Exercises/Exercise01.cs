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
            try
            {
                int selected;
                double temperature;
                double result;
                string[] options = { "Celsius para Fahrenheit", "Fahrenheit para Celsius" };
                selected = Menu.DisplayMenu(options);

                while (true)
                {
                    Console.Write("Digite a temperatura a ser convertida: ");
                    if (double.TryParse(Console.ReadLine(), out temperature))
                        break;
                    else
                    {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                        Menu.WaitInput();
                    }
                }

                switch (selected)
                {
                    case 0:
                        result = CelsiusToFahrenheit(temperature);
                        Console.WriteLine($"{temperature} °C é igual a {result} °F.");
                        break;
                    case 1:
                        result = FahrenheitToCelsius(temperature);
                        Console.WriteLine($"{temperature} °F é igual a {result} °C.");
                        break;
                }
                Menu.WaitInput();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
