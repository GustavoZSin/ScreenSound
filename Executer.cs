using ScreenSound.Menus;
using ScreenSound.Models;

namespace ScreenSound
{
    internal class Executer
    {
        //TODO add option to add music in an album or band
        Dictionary<int, Menu> MenuOptions = new Dictionary<int, Menu>()
        {{-1, new MenuLeave() },
         { 1, new MenuBandRegister() },
         { 2, new MenuAlbumRegister() },
         { 3, new MenuShowAllBands() },
         { 4, new MenuBandAvaliate() },
         { 5, new MenuShowDetails() },};

        internal void StartExecution() => InitialMenu();
        internal void InitialMenu()
        {
            ShowStartMessageInConsole();

            Console.WriteLine("\nType 1 to register a band");
            Console.WriteLine("Type 2 to register an album");
            Console.WriteLine("Type 3 to show all bands");
            Console.WriteLine("Type 4 to rate a band");
            Console.WriteLine("Type 5 details of a band");
            Console.WriteLine("Type -1 to leave");
            Console.Write("\nType your option: ");

            int chosenNumber = GetChosenOption();
            ManageOptions(chosenNumber);
        }
        private void ShowStartMessageInConsole()
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

            Console.WriteLine("\nWelcome to Screen Sound");
        }
        private int GetChosenOption()
        {
            string chosenOption = Console.ReadLine()!;
            return int.Parse(chosenOption);
        }
        private void ManageOptions(int chosenNumber)
        {
            if (MenuOptions.ContainsKey(chosenNumber))
            {
                Menu menu = MenuOptions[chosenNumber];
                menu.Execute();
            }
        }
    }
}