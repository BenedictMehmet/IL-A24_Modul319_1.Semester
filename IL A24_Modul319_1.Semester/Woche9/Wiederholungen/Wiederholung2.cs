using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche9.Wiederholungen
{
    internal class Wiederholung2
    {
        static void Main()
        {
            int x = 7;
            int y = 4;
            int z = 2;

            // Verschachtelte Zuweisung mit Inkrement und Dekrement
            z = ++x - y-- + (z++ * 2);  // z = 8 - 4 + (2 * 2), dann y wird zu 3, und z wird zu 8
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");
            y = x % z;                  // y = 8 % ^8 = 0 (Modulo-Operator: Rest der Division)
            Console.WriteLine($"");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");
            x = z / ++y;                // y wird zuerst zu 1 erhöht, dann x = 4 / 1 = 4
            Console.WriteLine($"");
            // Ausgabe der Endwerte
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");
        }
    }
}
