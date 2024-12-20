using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche9.Wiederholungen
{
    internal class doWhile
    {
        static void main(string[] args)
        {
            int zahl;
            do
            {
                Console.WriteLine("Gib eine Zahl grösser als 10 ein:");
                zahl = Convert.ToInt32(Console.ReadLine());
            } while (zahl <= 10);

            // da brauche ich noch eine alternative:
            Console.WriteLine("Danke du hast  eingegeben.");
        }
    }
}
