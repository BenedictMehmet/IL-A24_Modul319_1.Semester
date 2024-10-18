using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche7.Lösung4Switch
{
    internal class Lösung4Switch
    {
        static void Main()
        {
            Console.WriteLine("Wählen Sie einen Menüpunkt:");
            Console.WriteLine("1. Pizza - 8.99 EUR");
            Console.WriteLine("2. Pasta - 7.99 EUR");
            Console.WriteLine("3. Salat - 5.99 EUR");
            Console.WriteLine("4. Burger - 6.99 EUR");
            Console.WriteLine("5. Getränk - 2.99 EUR");

            Console.Write("Bitte wählen Sie eine Zahl (1-5): ");
            int auswahl = Convert.ToInt32(Console.ReadLine());

            switch (auswahl)
            {
                case 1:
                    Console.WriteLine("Pizza - 8.99 EUR");
                    break;
                case 2:
                    Console.WriteLine("Pasta - 7.99 EUR");
                    break;
                case 3:
                    Console.WriteLine("Salat - 5.99 EUR");
                    break;
                case 4:
                    Console.WriteLine("Burger - 6.99 EUR");
                    break;
                case 5:
                    Console.WriteLine("Getränk - 2.99 EUR");
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
    }

}

