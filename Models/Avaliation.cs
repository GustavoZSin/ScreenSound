using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class Avaliation
    {
        public int Rate { get; set; }
        public Avaliation(int rate)
        {
            if (rate < 0) rate = 0;
            if (rate > 10) rate = 10;

            Rate = rate;
        }
        public static Avaliation Parse(string text)
        {
            int rating = int.Parse(text);

            return new Avaliation(rating);
        }
    }
}
