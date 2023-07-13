using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    public class Album
    {
        public Album(string albumName)
        {
            AlbumName = albumName;
        }
        internal List<Music> MusicsOfTheAlbum = new List<Music>();
        public string AlbumName { get; set; }
        public int TotalDuration => MusicsOfTheAlbum.Sum(m => m.DurationTime);

        public void AddSongToAlbum(Music song) => MusicsOfTheAlbum.Add(song);
        public void ShowAlbumSongs()
        {
            Console.WriteLine($"List of musics of the album {AlbumName}:\n");
            foreach (Music song in MusicsOfTheAlbum)
            {
                Console.WriteLine($"Music: {song.MusicName}");
            }
            Console.WriteLine($"\nTo listening this album, you'll need {TotalDuration} minutes");
        }
    }
}
