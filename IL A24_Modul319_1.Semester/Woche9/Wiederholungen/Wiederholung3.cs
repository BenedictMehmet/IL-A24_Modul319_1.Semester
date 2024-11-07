using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche9.Wiederholungen
{
    internal class Wiederholung3
    {
        static void Main()
        {
            int a = 10;
            int b = 20;

            // Vergleichsoperatoren
            bool result1 = a != b; // Prüft, ob a ungleich b ist
            bool result2 = a == b; // Prüft, ob a gleich b ist
            bool result3 = a < b;  // Prüft, ob a kleiner als b ist
            bool result4 = a > b;  // Prüft, ob a größer als b ist
            bool result5 = a <= b; // Prüft, ob a kleiner oder gleich b ist
            bool result6 = a >= b; // Prüft, ob a größer oder gleich b ist

            // Logischer Operator &&
            bool combinedResult = (a < b) && (a != b); // Prüft, ob beide Bedingungen wahr sind

            // Ausgabe der Ergebnisse
            Console.WriteLine($"a != b: {result1}"); // True, weil 10 != 20
            Console.WriteLine($"a == b: {result2}"); // False, weil 10 != 20
            Console.WriteLine($"a < b: {result3}");  // True, weil 10 < 20
            Console.WriteLine($"a > b: {result4}");  // False, weil 10 < 20
            Console.WriteLine($"a <= b: {result5}"); // True, weil 10 <= 20
            Console.WriteLine($"a >= b: {result6}"); // False, weil 10 < 20
            Console.WriteLine($"(a < b) && (a != b): {combinedResult}"); // True, weil beide Bedingungen wahr sind
        }
    }
}
