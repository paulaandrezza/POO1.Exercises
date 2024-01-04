using POO1.Exercises.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO1.Exercises.Exercises
{
    internal class Exercise07 : Exercise
    {
        public override void Execute()
        {
            try
            {
                while (true)
                {
                    Console.Write("Digite o valor em reais: R$ ");

                    if (double.TryParse(Console.ReadLine(), out double valueReal) && valueReal >= 0)
                    {
                        while(true)
                        {
                            Console.Write("Digite a cotação do dólar: $ ");

                            if (double.TryParse(Console.ReadLine(), out double dollarExchangeRate) && dollarExchangeRate > 0)
                            {
                                double valueDolar = valueReal / dollarExchangeRate;
                                Console.WriteLine($"R$ {valueReal} convertido em dólares é: $ {valueDolar:F2}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Por favor, digite uma cotação do dólar válida.");
                                Menu.WaitInput();
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um valor em reais válido.");
                        Menu.WaitInput();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
