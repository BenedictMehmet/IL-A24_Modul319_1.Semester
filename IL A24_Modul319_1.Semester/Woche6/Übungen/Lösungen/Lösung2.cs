using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche6.Übungen.Lösungen
{
    internal class Lösung2
    {
        static void Main(string[] args)
        {
            int personAge = 30;  // Beispielwert, kann geändert werden.

            if (personAge < 12 || personAge > 65)
            {
                Console.WriteLine("Ermäßigung gewährt");
            }
            else
            {
                Console.WriteLine("Keine Ermäßigung");
            }
        }




    }
}
