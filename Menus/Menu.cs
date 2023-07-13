using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class Menu
    {
        internal virtual void Execute()
        {
            ReturnToInitialMenu();
        }
        public static void ShowSubtitleSection(string sectionName)
        {
            Console.Clear();

            int quantityOfAsterisks = sectionName.Length;
            string formatedAsterisks = string.Empty.PadLeft(quantityOfAsterisks, '*');

            Console.WriteLine(formatedAsterisks);
            Console.WriteLine(sectionName);
            Console.WriteLine(formatedAsterisks + "\n");
        }
        public static void ReturnToInitialMenu()
        {
            Console.WriteLine("\nType anithing to back to the initial menu");
            Console.ReadKey();
            Console.Clear();

            Executer executer = new Executer();
            executer.InitialMenu();
        }
    }
}
