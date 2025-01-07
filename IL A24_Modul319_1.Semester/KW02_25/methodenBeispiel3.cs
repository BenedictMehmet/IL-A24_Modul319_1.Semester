using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.KW02_25
{
    internal class methodenBeispiel3
    {
        internal void ZeigeWetter()
        {
            Console.WriteLine("Das aktuelle Wetter ist sonnig mit 25°C.");
        }
    }

    class MethodenBeispiel3
    {
        static void Main()
        {
            methodenBeispiel3 wetter = new methodenBeispiel3();
            wetter.ZeigeWetter();
        }
    }
}
