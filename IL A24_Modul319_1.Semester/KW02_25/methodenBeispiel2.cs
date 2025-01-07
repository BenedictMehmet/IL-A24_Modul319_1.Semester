using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.KW02_25
{
    internal class MethodenBeispiel2
    {

        // Das Schlüsselwort return wird in einer Methode verwendet,
        // um einen Wert zurückzugeben und die Methode zu beenden.
        // Daher braucht es keinen Void!

        internal int Multipliziere()
        {
            return 4 * 5;
        }
    }

    class methodenBeispiel2
    {
        static void Main()
        {
            MethodenBeispiel2 rechner = new MethodenBeispiel2();
            int ergebnis = rechner.Multipliziere();
            Console.WriteLine("Das Produkt ist: " + ergebnis);
        }
    }
}
