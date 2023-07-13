using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRateAlbum : Menu
    {
        internal override void Execute()
        {
            SetReviewToAnAlbum();
        }

        private void SetReviewToAnAlbum()
        {
            ShowSubtitleSection("Review the Album");

            Console.Write("Type the band that you want to rate the album: ");
            string bandToReview = Console.ReadLine()!;

            if (Band.bandList.ContainsKey(bandToReview))
            {
                Band band = Band.bandList[bandToReview];
                Console.Write("Type the name of the album that you want to register: ");
                string albumName = Console.ReadLine()!;

                if (band.Albums.Any(a => a.AlbumName.Equals(albumName)))
                {
                    Album album = band.Albums.First(a => a.AlbumName.Equals(albumName));
                    Console.Write($"What's your rating to the album {albumName}? ");
                    Avaliation rating = Avaliation.Parse(Console.ReadLine()!);

                    album.AddAvaliation(rating);

                    Console.WriteLine($"\nYour rating was added to the album {albumName}. Thank you for the contribuition.");
                    base.Execute();
                }
                else
                {
                    Console.WriteLine($"Album '{albumName}' not found.");
                    base.Execute();
                }
            }
            else
            {
                Console.WriteLine($"Band '{bandToReview}' not found.");
                base.Execute();
            }
        }
    }
}
