using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.KW02_25
{
    internal class methodenParameter1
    {
        internal void SageHallo(string name) // Methode mit Parameter
        {
            Console.WriteLine("Hallo, " + name + "! Willkommen im Programm.");
        }
    }

    class MethodenParameter1
    {
        static void Main()
        {
            methodenParameter1 begruesser = new methodenParameter1();

            begruesser.SageHallo("Max"); // Beim Aufruf können in Klammer Namen eingesetzt werden, da Parameter vorhanden
            begruesser.SageHallo("Anna");
        }
    }
}
