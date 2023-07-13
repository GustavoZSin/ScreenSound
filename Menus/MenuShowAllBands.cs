using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class MenuShowAllBands : Menu
    {
        internal override void Execute()
        {
            ShowAllRegisteredsBands();
        }
        private void ShowAllRegisteredsBands()
        {
            ShowSubtitleSection("List Of Bands");

            foreach (string band in Band.bandList.Keys)
            {
                Console.WriteLine($"Band: {band}");
            }

            base.Execute();
        }
    }
}
