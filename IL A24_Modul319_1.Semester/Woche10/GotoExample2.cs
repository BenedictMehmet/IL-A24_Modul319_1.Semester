using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche10
{
    internal class GotoExample2
    {
        static void Main()
        {
            Console.WriteLine("Beispiel für die Verwendung von goto in einem Switch-Case:");

            int option;

            // Schleife, die fortfährt, bis eine gültige Option eingegeben wird
            while (true)
            {
                try
                {
                    // Benutzer nach einer Option fragen
                    Console.Write("Bitte eine Option auswählen (1, 2 oder 3): ");
                    option = Convert.ToInt32(Console.ReadLine()); // Benutzereingabe lesen

                    // Switch-Case mit goto-Anweisungen
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Option 1 gewählt.");
                            break;

                        case 2:
                            Console.WriteLine("Option 2 gewählt. Springe zu Option 3.");
                            // Springe direkt zu Fall 3
                            goto case 3;

                        case 3:
                            Console.WriteLine("Option 3 gewählt.");
                            break;

                        default:
                            // Ungültige Option
                            Console.WriteLine("Ungültige Option. Bitte geben Sie 1, 2 oder 3 ein.");
                            continue; // Springt zurück zum Anfang der Schleife und fordert eine neue Eingabe
                    }

                    // Wenn eine gültige Option gewählt wurde, die Schleife verlassen
                    break;
                }
                catch (FormatException)
                {
                    // Fehlermeldung bei ungültiger Eingabe (z.B. Text statt Zahl)
                    Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Zahl eingeben.");
                }
            }

            Console.WriteLine("Switch-Case mit goto beendet.\n");
        }
    }
}
