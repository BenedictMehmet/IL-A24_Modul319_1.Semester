using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche7.Wiederholung3Switch
{
    internal class Wiederholung3Switch
    {
 
        static void Main()
        {
            int tag = 3;
            string wochentag;

            switch (tag)
            {
                case 1:
                    wochentag = "Montag";
                    break;
                case 2:
                    wochentag = "Dienstag";
                    break;
                case 3:
                    wochentag = "Mittwoch";
                    break;
                case 4:
                    wochentag = "Donnerstag";
                    break;
                case 5:
                    wochentag = "Freitag";
                    break;
                case 6:
                    wochentag = "Samstag";
                    break;
                case 7:
                    wochentag = "Sonntag";
                    break;
                default:
                    wochentag = "Ungültiger Tag";
                    break;
            }

            Console.WriteLine("Der Tag ist: " + wochentag);
        }
    }

}

