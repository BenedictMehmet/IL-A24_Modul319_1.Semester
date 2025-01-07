using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.KW02_25.Übungen.Lösungen
{
    internal class Lösung1
    {
        internal void IstGerade(int zahl)
        {
            if (zahl % 2 == 0)
                Console.WriteLine(zahl + " ist eine gerade Zahl.");
            else
                Console.WriteLine(zahl + " ist eine ungerade Zahl.");
        }
    }

    class lösung1
    {
        static void Main()
        {
            Lösung1 pruefer = new Lösung1();
            pruefer.IstGerade(7);
            pruefer.IstGerade(10);
        }
    }
}
