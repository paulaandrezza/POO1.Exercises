using POO1.Exercises.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1.Exercises.Exercises
{
    internal class Exercise02 : Exercise
    {
        public override void Execute()
        {
            try
            {
                while (true)
                {
                    Console.Write("Informe um número inteiro positivo que deseja verificar se é primo ou não: ");
                    if (int.TryParse(Console.ReadLine(), out int number) && number > 1)
                    {
                        if (IsPrime(number))
                            Console.WriteLine($"{number} é um número primo.");
                        else
                            Console.WriteLine($"{number} não é um número primo.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um número inteiro positivo maior que 1.");
                        Menu.WaitInput();
                    }
                }
                Menu.WaitInput();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
