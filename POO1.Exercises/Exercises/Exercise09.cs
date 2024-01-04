using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1.Exercises.Exercises
{
    internal class Exercise09 : Exercise
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Digite o CPF que deseja validar (apenas numeros): ");
                string cpf = Console.ReadLine();

                if (ValidateCPF(cpf))
                    Console.WriteLine("CPF válido.");
                else
                    Console.WriteLine("CPF inválido.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static bool ValidateCPF(string cpf)
        {
            if (cpf.Length != 11 || !long.TryParse(cpf, out _))
                return false;

            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += int.Parse(cpf[i].ToString()) * (10 - i);
            
            int resto = sum % 11;
            int firstCheckDigit = (resto < 2) ? 0 : 11 - resto;

            if (int.Parse(cpf[9].ToString()) != firstCheckDigit)
                return false;

            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            resto = sum % 11;
            int secondCheckDigit = (resto < 2) ? 0 : 11 - resto;

            return int.Parse(cpf[10].ToString()) == secondCheckDigit;
        }
    }
}
