using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche6.Wiederholungen
{
    internal class _1
    {
        static void Main(string[] args)
        {
            // Beispiel: Benutzer-Authentifizierung

            Console.WriteLine("Bitte geben Sie Ihren Benutzernamen ein:");
            string username = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihr Passwort ein:");
            string password = Console.ReadLine();

            // Dummy-Daten für Benutzerauthentifizierung
            string correctUsername = "admin";
            string correctPassword = "1234";

            // if/else Bedingung für Authentifizierung
            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Zugang gewährt. Willkommen!");
            }
            else if (username == correctUsername && password != correctPassword)
            {
                Console.WriteLine("Falsches Passwort. Zugang verweigert.");
            }
            else
            {
                Console.WriteLine("Unbekannter Benutzername. Zugang verweigert.");
            }

            // Weitere Logik könnte hier folgen...

            Console.WriteLine("Programm beendet. Drücken Sie eine beliebige Taste, um zu beenden.");
            Console.ReadKey();
        }
    }
}

