using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche6.Wiederholungen
{
    internal class _4
    {
        static void Main(string[] args)
        {
            // Beispiel: Berechnung des Eintrittspreises für ein Museum

            Console.WriteLine("Bitte geben Sie Ihr Alter ein:");
            int age;
            bool isNumeric = int.TryParse(Console.ReadLine(), out age);

            if (isNumeric)
            {
                // if/else Bedingung für Eintrittspreise
                if (age < 6)
                {
                    Console.WriteLine("Eintritt frei.");
                }
                else if (age >= 6 && age <= 18)
                {
                    Console.WriteLine("Eintrittspreis: 5 Euro.");
                }
                else if (age > 18 && age < 65)
                {
                    Console.WriteLine("Eintrittspreis: 10 Euro.");
                }
                else
                {
                    Console.WriteLine("Eintrittspreis: 7 Euro (Seniorenrabatt).");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
            }

            Console.WriteLine("Programm beendet. Drücken Sie eine beliebige Taste, um zu beenden.");
            Console.ReadKey();
        }
    }
}

