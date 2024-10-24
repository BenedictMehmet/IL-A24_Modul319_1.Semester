using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche8.Übungen.Lösungen
{
    internal class Lösung1
    {
        public static void Main(string[] args)
        {
            int zahl;

            // do-while Schleife zur Eingabe einer Zahl zwischen 5 und 15
            do
            {
                Console.Write("Bitte eine Zahl zwischen 5 und 15 eingeben: ");
                zahl = Convert.ToInt32(Console.ReadLine());
            }
            while (zahl < 5 || zahl > 15); // Bedingung: Zahl muss zwischen 5 und 15 liegen

            // Typumwandlung von int zu double
            double gleitkommazahl = (double)zahl;

            Console.WriteLine("Die eingegebene Zahl als Ganzzahl: " + zahl);
            Console.WriteLine("Die eingegebene Zahl als Gleitkommazahl: " + gleitkommazahl);
        }
    }
}
