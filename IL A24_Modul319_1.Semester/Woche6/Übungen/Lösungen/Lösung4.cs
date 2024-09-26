using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche6.Übungen.Lösungen
{
    internal class Lösung4
    {
        static void Main(string[] args)
        {
            int year = 2024;  // Beispielwert, kann geändert werden.

            if (year % 400 == 0)
            {
                Console.WriteLine("Schaltjahr");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Kein Schaltjahr");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("Schaltjahr");
            }
            else
            {
                Console.WriteLine("Kein Schaltjahr");
            }
        }




    }
}
