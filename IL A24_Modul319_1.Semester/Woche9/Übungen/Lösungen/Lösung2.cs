using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche9.Übungen.Lösungen
{
    internal class Lösung2
    {
        static void Main()
        {
            int i = 5;
            int j = 10;

            // Zuweisungen und Inkremente
            i = j;        // i wird auf den Wert von j gesetzt (i = 10)
            Console.WriteLine($"i = {i}");

            i++;          // i wird um 1 erhöht (i = 11)
            Console.WriteLine($"i++: {i}");

            j--;          // j wird um 1 verringert (j = 9)
            Console.WriteLine($"j--: {j}");

            i += j;       // i wird um den Wert von j erhöht (i = 20)
            Console.WriteLine($"i += j: {i}");

            j *= 2;       // j wird mit 2 multipliziert (j = 18)
            Console.WriteLine($"j *= 2: {j}");
        }
    }
}
