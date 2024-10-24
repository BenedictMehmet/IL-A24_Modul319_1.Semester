using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche8.Wiederholungen
{
    internal class DoWhileTernaryOperatorBeispiel
    {
        public static void Main(string[] args)
        {
            int zahl;
            string ergebnis;

            // do-while Schleife zur Überprüfung der Zahl und Nutzung des Bedingungsoperators
            do
            {
                Console.Write("Bitte eine Zahl eingeben (zwischen 0 und 100): ");
                zahl = Convert.ToInt32(Console.ReadLine()); // Benutzereingabe lesen

                // Bedingungsoperator ? : um festzustellen, ob die Zahl gerade oder ungerade ist
                ergebnis = (zahl % 2 == 0) ? "gerade" : "ungerade";
                Console.WriteLine("Die Zahl ist " + ergebnis);

            }
            while (zahl < 0 || zahl > 100); // Schleife läuft, solange die Zahl ausserhalb des Bereichs 0-100 ist

            Console.WriteLine("Die Zahl liegt zwischen 0 und 100 und ist " + ergebnis + ".");
        }
    }
}
