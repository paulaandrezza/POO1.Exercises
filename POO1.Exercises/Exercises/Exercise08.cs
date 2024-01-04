using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POO1.Exercises.Exercises
{
    internal class Exercise08 : Exercise
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Digite a senha que deseja validar: ");
                string password = Console.ReadLine();

                if (ValidatePassword(password))
                    Console.WriteLine("Senha válida!");
                else
                    Console.WriteLine("Senha inválida. Certifique-se de que atende aos critérios.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static bool ValidatePassword(string password)
        {
            Regex regexPassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
            return regexPassword.IsMatch(password);
        }
    }
}
