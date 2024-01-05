using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POO1.Exercises.Exercises
{
    internal class Exercise10 : Exercise
    {
        public override void Execute()
        {
            Console.WriteLine("Digite um texto:");
            string text = Console.ReadLine();

            text = Regex.Replace(text.ToLower(), @"[^a-z\s]", " ");

            Console.WriteLine(text);

            string[] words = Regex.Split(text.Trim(), @"\s+|\t+");

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }

            Console.WriteLine("\nFrequência das Palavras:");
            foreach (var item in wordCount)
                Console.WriteLine($"{item.Key}: {item.Value} vezes");

        }
    }
}
