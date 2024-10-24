using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche8.Wiederholungen
{
    internal class DoWhileSwitchBeispiel
    {

        public static void Main(string[] args)
        {
            int option;

            // do-while Schleife mit switch-case zur Auswahl von Optionen
            do
            {
                // Menü anzeigen
                Console.WriteLine("Menü:");
                Console.WriteLine("1 - Option 1");
                Console.WriteLine("2 - Option 2");
                Console.WriteLine("3 - Beenden");
                Console.Write("Bitte wählen Sie eine Option (1-3): ");
                option = Convert.ToInt32(Console.ReadLine()); // Benutzereingabe

                // Switch zur Auswahl der Option
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Sie haben Option 1 gewählt.");
                        break;
                    case 2:
                        Console.WriteLine("Sie haben Option 2 gewählt.");
                        break;
                    case 3:
                        Console.WriteLine("Programm wird beendet.");
                        break;
                    default:
                        Console.WriteLine("Ungültige Option. Bitte erneut versuchen.");
                        break;
                }
            }
            while (option != 3); // Schleife läuft, bis der Benutzer die Option 3 wählt
        }

    }
}
