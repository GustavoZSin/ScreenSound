using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuLeave : Menu
    {
        internal override void Execute()
        {
            CloseApplication();
        }
        private void CloseApplication()
        {
            Console.WriteLine("Closing.....");
        }
    }
}
