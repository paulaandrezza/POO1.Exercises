using POO1.Exercises.Exercises;
using POO1.Exercises.UI;

namespace POO1.Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise[] exercises =
            [
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
            ];
            while (true)
            {
                var options = Menu.GenerateOptions(exercises.Length);
                exercises[Menu.DisplayMenu(options, Title.TitleExercises())].Execute();
            }
        }
    }
}
