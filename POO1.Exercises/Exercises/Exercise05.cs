using POO1.Exercises.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POO1.Exercises.Exercises
{
    internal class Exercise05 : Exercise
    {
        public override void Execute()
        {
            try
            {
                while (true)
                {
                    Console.Write("Digite uma palavra: ");
                    string word = Console.ReadLine();

                    if (IsPalindromo(word))
                        Console.WriteLine($"{word} é um palíndromo.");
                    else
                        Console.WriteLine($"{word} não é um palíndromo.");
                    break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static bool IsPalindromo(string word)
        {
            word = word.Replace(" ", "").ToLower();

            int wordLength = word.Length;
            Console.WriteLine(wordLength/2);
            for (int i = 0; i < wordLength / 2; i++)
            {
                Console.WriteLine($"Comparando {word[i]} com word {word[wordLength - i - 1]}");
                if (word[i] != word[wordLength - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
