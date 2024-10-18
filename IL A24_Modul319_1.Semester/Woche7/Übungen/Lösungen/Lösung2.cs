using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche7.Lösung2
{
    internal class Lösung2
    {
        static void Main()
        {
            Console.Write("Bitte geben Sie Ihr Alter ein: ");
            int alter = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte geben Sie den Fahrzeugtyp ein (Normal oder Sportwagen): ");
            string fahrzeugtyp = Console.ReadLine();

            Console.Write("Bitte geben Sie Ihren Wohnort ein (Stadt oder Land): ");
            string wohnort = Console.ReadLine();

            double basisPraemie = 1000.0;

            double praemie = alter < 25 ? basisPraemie * 1.10 : basisPraemie * 0.95;
            praemie = fahrzeugtyp == "Sportwagen" ? praemie * 1.20 : praemie;
            praemie = wohnort == "Stadt" ? praemie * 1.15 : praemie;

            Console.WriteLine("Die Versicherungsprämie beträgt: " + praemie + " EUR");
        }
    }

}

