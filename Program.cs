using PrivateScoolSystem.Menu;

namespace PrivateScoolSystem
{
   internal class Program
    {
       private static void Main()
        {
            Application.Run();
        }
    }
   internal class Application
    {
        public static void Run()
        {
            var menu = new StartMenu();
            menu.MainMenu();
        }
    }
}
