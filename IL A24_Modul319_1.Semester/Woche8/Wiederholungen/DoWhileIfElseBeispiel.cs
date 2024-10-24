using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche8.Wiederholungen
{
    internal class DoWhileIfElseBeispiel
    {
        public static void Main(string[] args)
        {
            int eingabe;

            // do-while Schleife zur Eingabevalidierung mit if/else
            do
            {
                Console.Write("Bitte eine Zahl zwischen 1 und 10 eingeben: ");
                eingabe = Convert.ToInt32(Console.ReadLine()); // Benutzereingabe lesen

                // Überprüfen, ob die Eingabe gültig ist
                // if/else erklärt, ob es stimmt oder nicht! -> Kontrolle!
                if (eingabe < 1)
                {
                    Console.WriteLine("Die Zahl ist zu klein. Bitte erneut versuchen.");
                }
                else if (eingabe > 10)
                {
                    Console.WriteLine("Die Zahl ist zu groß. Bitte erneut versuchen.");
                }
            }
            //while schleife kann den Vorgang wiederholen aber nicht kontrollieren! Wiederholung!
            while (eingabe < 1 || eingabe > 10); // Schleife läuft, bis eine Zahl zwischen 1 und 10 eingegeben wird

            // Erfolgreiche Eingabe
            Console.WriteLine("Gültige Zahl eingegeben: " + eingabe);
        }

    }
}
