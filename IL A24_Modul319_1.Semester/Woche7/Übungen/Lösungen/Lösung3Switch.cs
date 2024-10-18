using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche7.Lösung3Switch
{
    internal class Lösung3Switch
    {
        static void Main()
        {
            Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 7 ein: ");
            int tag = Convert.ToInt32(Console.ReadLine());

            switch (tag)
            {
                case 1:
                    Console.WriteLine("Montag");
                    break;
                case 2:
                    Console.WriteLine("Dienstag");
                    break;
                case 3:
                    Console.WriteLine("Mittwoch");
                    break;
                case 4:
                    Console.WriteLine("Donnerstag");
                    break;
                case 5:
                    Console.WriteLine("Freitag");
                    break;
                case 6:
                    Console.WriteLine("Samstag");
                    break;
                case 7:
                    Console.WriteLine("Sonntag");
                    break;
                default:
                    Console.WriteLine("Ungültiger Tag");
                    break;
            }
        }
    }

}

