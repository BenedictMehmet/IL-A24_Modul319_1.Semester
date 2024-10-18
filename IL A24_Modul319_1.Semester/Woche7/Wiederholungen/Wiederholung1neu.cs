using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche7.Wiederholung1neu
{
    internal class Wiederholung1neu
    {
        static void Main()
        {
            int alter = 22;

            // Komplexere Bedingungskette mit dem Bedingungsoperator `?:`
            string ticket = alter < 12
                            ? "Kinderticket"
                            : alter >= 12 && alter < 18
                            ? "Jugendticket"
                            : alter >= 18 && alter < 65
                            ? "Erwachsenenticket"
                            : "Seniorenticket";

            Console.WriteLine("Tickettyp: " + ticket);
        }
    }
}

