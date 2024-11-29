using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche10
{
    internal class LoopControlExamples
    {
        static void Main(string[] args)
        {
            // Aufruf der Methode ProcessNumbers
            DemonstrateBreakAndContinue();
        }
        public static void DemonstrateBreakAndContinue()
        {
            Console.WriteLine("Beispiel für die Verwendung von break und continue:");

            // Eine Schleife, die von 1 bis 10 zählt
            for (int i = 1; i <= 10; i++)
            {
                // Überprüfung, ob die aktuelle Zahl gerade ist
                if (i % 2 == 0)
                {
                    // Wenn die Zahl gerade ist, wird der Rest des Codes in dieser Iteration übersprungen
                    // und die Schleife springt zur nächsten Iteration
                    Console.WriteLine("Gerade Zahl: " + i + " wird übersprungen.");
                    continue; // Überspringt den Rest des Codes und setzt die Schleife mit der nächsten Zahl fort
                }

                // Ausgabe der aktuellen ungeraden Zahl
                Console.WriteLine("Ungerade Zahl: " + i);

                // Überprüfung, ob die Zahl 7 erreicht wurde
                if (i == 7)
                {
                    // Wenn die Zahl 7 erreicht wird, wird die Schleife abgebrochen
                    Console.WriteLine("Zahl 7 erreicht. Schleife wird abgebrochen.");
                    break; // Beendet die Schleife vollständig
                }
            }

            // Dieser Code wird nach dem Abbruch der Schleife ausgeführt
            Console.WriteLine("Die Schleife wurde beendet.\n");
        }
    }
}
