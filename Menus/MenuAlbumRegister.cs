using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class MenuAlbumRegister : Menu
    {
        internal override void Execute()
        {
            RegisterAlbum();
        }
        private void RegisterAlbum()
        {
            ShowSubtitleSection("Album Register");

            Console.Write("Type the band name that you want to register the album: ");
            string bandName = Console.ReadLine()!;

            if (Band.bandList.ContainsKey(bandName))
            {
                Console.Write("Type the name of the album that you want to register: ");
                string albumName = Console.ReadLine()!;

                Band band = Band.bandList[bandName];
                band.AddAlbum(new Album(albumName));

                Console.WriteLine($"Album '{albumName}' from '{bandName}' was successfully registered.");
            }

            base.Execute();
        }
    }
}
