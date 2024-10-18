using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche7.Wiederholung1
{
    internal class Wiederholung1
    {
        static void Main()
        {
            int alter = 22;
            string ticket;

            if (alter < 12)
            {
                ticket = "Kinderticket";
            }
            else if (alter >= 12 && alter < 18)
            {
                ticket = "Jugendticket";
            }
            else if (alter >= 18 && alter < 65)
            {
                ticket = "Erwachsenenticket";
            }
            else
            {
                ticket = "Seniorenticket";
            }

            Console.WriteLine("Tickettyp: " + ticket);
        }
    }



}

