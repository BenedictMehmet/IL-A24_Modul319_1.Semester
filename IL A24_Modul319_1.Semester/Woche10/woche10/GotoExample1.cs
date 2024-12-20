using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche10
{
    internal class GotoExample1
    {
        static void Main()
        {
            LoopWithGoto();
        }
        public static void LoopWithGoto()
        {
            Console.WriteLine("Beispiel für die Verwendung von goto in einer Schleife:");

            int i = 0;

        // Definiere eine Markierung namens `Start`
        Start:
            // Erhöhe den Zähler
            i++;

            // Ausgabe der aktuellen Zählerposition
            Console.WriteLine("Aktueller Wert von i: " + i);

            // Überprüfe, ob i kleiner als 5 ist
            if (i < 5)
            {
                // Springe zurück zu `Start`, wenn die Bedingung erfüllt ist
                goto Start;
            }

            Console.WriteLine("Schleife mit goto beendet.\n");
        }
    }
}
