using POO1.Exercises.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POO1.Exercises.Exercises
{
    internal class Exercise04 : Exercise
    {
        public override void Execute()
        {
            try
            {
                while(true)
                {
                    Console.Write("Digite os números separados por espaço: ");
                    string input = Console.ReadLine();

                    if (!string.IsNullOrEmpty(input))
                    {
                        string[] numberStrings = Regex.Split(input.Trim(), @"\s+|\t+");

                        if (Array.TrueForAll(numberStrings, s => int.TryParse(s, out _)))
                        {
                            int[] numbers = Array.ConvertAll(numberStrings, int.Parse);
                            Array.Sort(numbers);
                            Console.WriteLine("Array ordenado em ordem crescente:");
                            foreach (int number in numbers)
                                Console.Write(number + " ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entrada Inválida. Tente novamente.");
                            Menu.WaitInput();
                        }
                    } else
                    {
                        Console.WriteLine("Por favor, insira pelo menos um número.");
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
