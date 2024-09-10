using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche4.Übungen.Lösungen
{
    internal class Schüler
    {

        // Instanzvariablen für die Klasse Schüler
        public string Vorname;
        public string Nachname;
        public int Klassenstufe;

        // Konstruktor zum Initialisieren der Instanzvariablen
        public Schüler(string vorname, string nachname, int klassenstufe)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Klassenstufe = klassenstufe;
        }

        // Main-Methode für die Ausgabe
        static void Main(string[] args)
        {
            // Instanz der Klasse erstellen
            Schüler schueler1 = new Schüler("Lena", "Schmidt", 10);

            // Ausgabe der Schülerinformationen
            Console.WriteLine($"Schüler: {schueler1.Vorname} {schueler1.Nachname}, Klassenstufe: {schueler1.Klassenstufe}");
            Console.ReadLine();
        }

    }
}
