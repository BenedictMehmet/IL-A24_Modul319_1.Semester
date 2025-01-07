using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.KW02_25.Übungen.Lösungen
{
    internal class Lösung3
    {
        internal void ZaehleBis(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine("Zahl: " + i);
            }
        }
    }

    class lösung3
    {
        static void Main(string[] args)
        {
            Lösung3 zaehler = new Lösung3();
            zaehler.ZaehleBis(5);
        }
    }
}
