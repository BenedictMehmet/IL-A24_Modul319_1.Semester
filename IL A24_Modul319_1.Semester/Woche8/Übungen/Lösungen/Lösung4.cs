using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche8.Übungen.Lösungen
{
    internal class Lösung4
    {
        public static void Main(string[] args)
        {
            double dezimalzahl;

            // do-while Schleife zur Eingabe einer positiven Dezimalzahl
            do
            {
                Console.Write("Bitte eine positive Dezimalzahl eingeben: ");
                dezimalzahl = Convert.ToDouble(Console.ReadLine());
            }
            while (dezimalzahl <= 0); // Bedingung: Zahl muss positiv sein

            // Typumwandlung von double zu int (ganzzahlige Darstellung)
            int ganzeZahl = (int)dezimalzahl;

            Console.WriteLine("Die eingegebene Dezimalzahl als Ganzzahl: " + ganzeZahl);
        }
    }
}
