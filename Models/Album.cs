using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    public class Album : IAssessable
    {
        public Album(string albumName)
        {
            AlbumName = albumName;
        }
        internal List<Music> musicsOfTheAlbum = new List<Music>();
        private List<Avaliation> avaliations = new();
        public string AlbumName { get; set; }
        public int TotalDuration => musicsOfTheAlbum.Sum(m => m.DurationTime);

        public double Average
        {
            get
            {
                if (avaliations.Count == 0) return 0;
                else return avaliations.Average(a => a.Rate);
            }
        }

        public void AddSongToAlbum(Music song) => musicsOfTheAlbum.Add(song);
        public void ShowAlbumSongs()
        {
            Console.WriteLine($"List of musics of the album {AlbumName}:\n");
            foreach (Music song in musicsOfTheAlbum)
            {
                Console.WriteLine($"Music: {song.MusicName}");
            }
            Console.WriteLine($"\nTo listening this album, you'll need {TotalDuration} minutes");
        }

        public void AddAvaliation(Avaliation rate)
        {
            avaliations.Add(rate);
        }
    }
}
