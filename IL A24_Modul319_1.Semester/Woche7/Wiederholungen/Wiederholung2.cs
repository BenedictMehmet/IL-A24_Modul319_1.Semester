using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche7.Wiederholung2
{
    internal class Wiederholung2
    {
 
        static void Main()
        {
            int menge = 20;
            string kundentyp = "Premium";
            double einzelpreis = 50.0;
            double rabatt;
            double endpreis;

            // Berechnung des Rabatts basierend auf Menge und Kundentyp
            if (menge >= 50)
            {
                if (kundentyp == "Premium")
                {
                    rabatt = 0.20; // 20% Rabatt für Premium-Kunden bei Großbestellungen
                }
                else
                {
                    rabatt = 0.10; // 10% Rabatt für Standard-Kunden bei Großbestellungen
                }
            }
            else if (menge >= 20)
            {
                if (kundentyp == "Premium")
                {
                    rabatt = 0.15; // 15% Rabatt für Premium-Kunden
                }
                else
                {
                    rabatt = 0.05; // 5% Rabatt für Standard-Kunden
                }
            }
            else
            {
                if (kundentyp == "Premium")
                {
                    rabatt = 0.10; // 10% Rabatt für Premium-Kunden
                }
                else
                {
                    rabatt = 0.0; // Kein Rabatt für Standard-Kunden
                }
            }

            // Berechnung des Endpreises
            endpreis = menge * einzelpreis * (1 - rabatt);

            Console.WriteLine("Endpreis: " + endpreis + " EUR");
        }
    }


}

