using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche10
{
    internal class NumberProcessor
    {
        static void Main(string[] args)
        {
            // Aufruf der Methode ProcessNumbers
            ProcessNumbers();
        }

        // Korrekt definierte Methode auf Klassenebene
        private static void ProcessNumbers()
        {
            Console.WriteLine("Beispiel für die Verwendung von break und continue in einer Zahlenverarbeitung:");

            // Eine Schleife, die von 1 bis 15 zählt
            for (int i = 1; i <= 15; i++)
            {
                // Überprüfung, ob die aktuelle Zahl durch 3 teilbar ist
                if (i % 3 == 0)
                {
                    // Wenn die Zahl durch 3 teilbar ist, überspringe den Rest der Schleife
                    Console.WriteLine("Zahl " + i + " ist durch 3 teilbar und wird übersprungen.");
                    continue; // Überspringt den Rest des Codes in der aktuellen Iteration
                }

                // Ausgabe der Zahl, wenn sie nicht durch 3 teilbar ist
                Console.WriteLine("Verarbeite Zahl: " + i);

                // Überprüfung, ob die Zahl größer als 10 ist
                if (i > 10)
                {
                    // Wenn die Zahl größer als 10 ist, wird die Schleife abgebrochen
                    Console.WriteLine("Zahl ist größer als 10. Schleife wird abgebrochen.");
                    break; // Beendet die Schleife vollständig
                }
            }

            // Dieser Code wird nach dem Abbruch der Schleife ausgeführt
            Console.WriteLine("Die Schleife wurde beendet.\n");
        }
    }
}
