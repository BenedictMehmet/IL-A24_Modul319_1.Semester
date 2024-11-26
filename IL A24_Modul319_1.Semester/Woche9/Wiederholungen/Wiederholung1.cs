using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche9.Wiederholungen
{
    internal class Wiederholung1
    {
        static void Main()
        {
            int i = 4;         // i wird auf 4 gesetzt
            int j = 3;         // j wird auf 3 gesetzt
            int k;

            // Zuweisung und Post-Inkrement
            k = i++ + j;       // k = 4 + 3, dann i = 5 (erst wird k berechnet, dann i erhöht)
            j = --k + i;       // k wird zuerst um 1 verringert, also k = 6, dann j = 6 + 5 = 11
            i = k-- - j;       // i = 6 - 11 = -5, dann k wird um 1 verringert, k = 5
            k += i * j;        // k = 5 + (-5) * 11 = 5 - 55 = -501

            // Ausgabe der Endwerte
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"j = {j}");
            Console.WriteLine($"k = {k}");
        }

    }
}
