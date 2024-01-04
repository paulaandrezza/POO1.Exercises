using POO1.Exercises.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1.Exercises.Exercises
{
    internal class Exercise03 : Exercise
    {
        public override void Execute()
        {
            try
            {
                while (true)
                {
                    Console.Write("Informe um número inteiro positivo que deseja calcular seu fatorial: ");
                    if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                    {
                        Console.WriteLine($"O fatorial de {number} é {Factorial(number)}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um número inteiro positivo maior que 0.");
                        Menu.WaitInput();
                    }
                }
                Menu.WaitInput();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            long result = 1;

            for (int i = 2; i <= n; i++)
                result *= i;

            return result;
        }
    }
}
