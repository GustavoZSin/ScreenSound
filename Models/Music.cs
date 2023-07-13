using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    public class Music
    {
        internal Music(Band artist, string musicName)
        {
            Artist = artist;
            MusicName = musicName;
        }

        public string MusicName { get; set; }
        internal Band Artist { get; }
        public int DurationTime { get; set; }
        public bool Available { get; set; }
        private string Description => $"Music {MusicName} belongs to the artist {Artist}";

        public void ShowMusicProperties()
        {
            Console.WriteLine($"Name:" + MusicName);
            Console.WriteLine($"Artist:" + Artist.BandName);
            Console.WriteLine($"Duration Time:" + DurationTime);
            Console.WriteLine($"Available:" + Available);
            Console.WriteLine($"Description:" + Description);
        }
    }
}
