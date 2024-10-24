using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche8.Übungen.Lösungen
{
    internal class Lösung2
    {
        public static void Main(string[] args)
        {
            int zahl;

            // do-while Schleife zur Eingabe einer Zahl grösser als 100
            do
            {
                Console.Write("Bitte eine Zahl größer als 100 eingeben: ");
                zahl = Convert.ToInt32(Console.ReadLine());
            }
            while (zahl <= 100); // Bedingung: Zahl muss grösser als 100 sein

            // Typumwandlung von int zu string
            string zahlAlsString = zahl.ToString();

            Console.WriteLine("Die eingegebene Zahl als String: " + zahlAlsString);
        }
    }
}
