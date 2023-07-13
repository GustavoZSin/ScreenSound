using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class Band : IAssessable
    {
        public static Dictionary<string, Band> bandList = new Dictionary<string, Band>();

        public List<Album> Albums = new List<Album>();

        private List<Avaliation> bandsAvaliation = new List<Avaliation>();
        public string BandName { get; set; }

        //TODO adicionar tratativa para evitar que ocorra quebra no código ao exibir uma nota de banda inexistente
        public double Average
        {
            get
            {
                if (bandsAvaliation.Count <= 0) return 0;
                else return bandsAvaliation.Average(a => a.Rate);
            }
        }
        public Band(string bandName)
        {
            BandName = bandName;
        }

        public void AddAvaliation(Avaliation avaliation) => bandsAvaliation.Add(avaliation);
        public void AddAlbum(Album album) => Albums.Add(album);
    }
}
