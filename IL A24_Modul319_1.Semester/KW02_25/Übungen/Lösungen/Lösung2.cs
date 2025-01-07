using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.KW02_25.Übungen.Lösungen
{
    internal class Lösung2
    {
        internal void Vergleiche(int zahl1, int zahl2)
        {
            if (zahl1 > zahl2)
                Console.WriteLine(zahl1 + " ist grösser als " + zahl2);
            else if (zahl1 < zahl2)
                Console.WriteLine(zahl1 + " ist kleiner als " + zahl2);
            else
                Console.WriteLine("Beide Zahlen sind gleich.");
        }
    }

    class lösung2
    {
        static void Main()
        {
            Lösung2 vergleich = new Lösung2();
            vergleich.Vergleiche(10, 5);
            vergleich.Vergleiche(3, 3);
        }
    }
}
