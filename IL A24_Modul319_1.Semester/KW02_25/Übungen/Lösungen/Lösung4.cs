using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.KW02_25.Übungen.Lösungen
{
    internal class Lösung4
    {
        internal int BerechneQuadrat(int zahl)
        {
            return zahl * zahl;
        }
    }

    class lösung4
    {
        static void Main(string[] args)
        {
            Lösung4 berechnung = new Lösung4();

            Console.WriteLine("Das Quadrat von 7 ist:" + berechnung.BerechneQuadrat(7));
            Console.WriteLine("Das Quadrat von 4 ist:" + berechnung.BerechneQuadrat(4));
        }
    }
}
