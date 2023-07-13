using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class MenuShowDetails : Menu
    {
        internal override void Execute()
        {
            ShowBandDetails();
        }
        internal void ShowBandDetails()
        {
            ShowSubtitleSection("Details of Band");
            
            Console.Write("Type the band that you want to know more: ");
            string bandName = Console.ReadLine()!;

            if (Band.bandList.ContainsKey(bandName))
            {
                Band band = Band.bandList[bandName];
                Console.Write($"The average rating to the band {band.BandName} is {band.Average}");

                Console.Write($"\nDiscography:");
                foreach(Album album in band.Albums)
                {
                    Console.WriteLine($"Album '{album.AlbumName}' -> {album.Average}");
                }

                base.Execute();
            }
            else
            {
                Console.WriteLine($"Band '{bandName}' not found.");
                base.Execute();
            }
        }

        //TODO add discography to show in CMD
        internal void ShowBandDiscography()
        {
            ShowSubtitleSection("Band Discography");

            Console.Write("Type the band that you want to show the discography: ");
            string bandName = Console.ReadLine()!;

            if (Band.bandList.ContainsKey(bandName))
            {
                Band band = Band.bandList[bandName];
                Console.WriteLine($"Discography of the band {band.BandName}:");

                foreach (Album album in band.Albums)
                {
                    Console.WriteLine($"Album: {album.AlbumName}. Total duration: {album.TotalDuration}");
                }

                base.Execute();
            }
            else
            {
                Console.WriteLine($"Band '{bandName}' not found.");
                base.Execute();
            }


        }
    }
}
