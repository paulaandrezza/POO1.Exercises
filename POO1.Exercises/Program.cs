using POO1.Exercises.Exercises;
using POO1.Exercises.UI;
using TaskManager;

namespace POO1.Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise[] exercises = new Exercise[]
            {
                new Exercise01(),
                new Exercise02(),
                new Exercise03(),
                new Exercise04(),
                new Exercise05(),
                new Exercise06(),
                new Exercise07(),
                new Exercise08(),
                new Exercise09(),
                new Exercise10(),
            };

            Console.WriteLine(Title.TitleExercises());
            ShowMenu(exercises.Length);
        }

        private static void ShowMenu(int lenghtItems)
        {
            Menu options = new Menu(lenghtItems);

            while (true)
            {
                Console.Clear();
                int selected = options.ShowMenu(Title.TitleExercises());
                if (selected >= 0 && selected <= lenghtItems)
                    break;
            }
        }
    }
}
