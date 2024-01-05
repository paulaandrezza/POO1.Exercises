using POO1.Exercises.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1.Exercises.Exercises
{
    internal class Exercise06 : Exercise
    {
        public override void Execute()
        {
            Console.WriteLine("Obs. Para realizar este cálculo, foi empregada a equação de Pell. Este método permite calcular a parte inteira da raiz quadrada. Em caso de um quadrado perfeito, o resultado será exato; entretanto, se não for um quadrado perfeito, o resultado será aproximado.\n\n");

            try
            {
                while (true)
                {
                    Console.Write("Digite o valor que deseja calcular a raiz quadrada (somente valores inteiros e maiores ou igual a 0): ");
                    if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
                    {
                        Console.WriteLine($"A raiz quadrada aproximada de {number} é: {SquareRootOfPell(number)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um número inteiro positivo maior ou igual a 0.");
                        Menu.WaitInput();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static int SquareRootOfPell(int number)
        {
            int count = 0;

            for(int i = 1; i <= number; i+=2)
            {
                number = number - i;
                count++;
            }

            return count;
        }
    }
}
