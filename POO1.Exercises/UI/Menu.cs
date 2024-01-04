using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Menu
    {
        private readonly int lenghtItems;
        private int selectedIndex;

        public Menu(int menuItems)
        {
            lenghtItems = menuItems;
            selectedIndex = 0;
        }

        public int ShowMenu(string? title = null)
        {
            ConsoleKeyInfo key;
            Console.CursorVisible = false;

            try
            {
                do
                {
                    Console.Clear();
                    RenderMenu(title);

                    key = Console.ReadKey(true);

                    HandleKeyPress(key);

                } while (key.Key != ConsoleKey.Enter);
            }
            finally
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.CursorVisible = true;
            }

            Console.WriteLine($"\nOpção selecionada: Exercício {selectedIndex+1:00}\n");
            return selectedIndex;
        }

        private void RenderMenu(string? title = null)
        {
            if (title != null)
            {
                Console.WriteLine(title);
            }

            Console.WriteLine("\nSelecione uma opção: \n");

            for (int i = 0; i < lenghtItems; i++)
            {
                Console.ForegroundColor = (i == selectedIndex) ? ConsoleColor.Black : ConsoleColor.Gray;
                Console.BackgroundColor = (i == selectedIndex) ? ConsoleColor.Gray : ConsoleColor.Black;

                Console.WriteLine($"Exercício {i+1:00}");

                Console.ResetColor();
            }

            Console.WriteLine("\nAperte enter para confirmar.");
        }

        private void HandleKeyPress(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = Math.Max(0, selectedIndex - 1);
                    break;

                case ConsoleKey.DownArrow:
                    selectedIndex = Math.Min(lenghtItems - 1, selectedIndex + 1);
                    break;
            }
        }
        public static void WaitInput()
        {
            Console.WriteLine("\nDigite qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public static int ReadInteger(string prompt)
        {
            int result;

            do
            {
                Console.Write(prompt + " ");
            } while (!int.TryParse(Console.ReadLine(), out result));

            return result;
        }
    }
}
