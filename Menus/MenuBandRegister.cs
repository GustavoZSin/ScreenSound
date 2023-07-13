using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class MenuBandRegister : Menu
    {
        internal override void Execute()
        {
            RegisterBand();
        }
        private void RegisterBand()
        {
            ShowSubtitleSection("Band Register");

            Console.Write("Type the band name that you want to register: ");
            string bandName = Console.ReadLine()!;

            if (!Band.BandList.ContainsKey(bandName))
            {
                Band.BandList.Add(bandName, new Band(bandName));
                Console.WriteLine($"{bandName} was successfully registered.");
            }
            else
            {
                Console.WriteLine($"The band '{bandName}' was already registered.");
            }

            base.Execute();
        }
    }
}
