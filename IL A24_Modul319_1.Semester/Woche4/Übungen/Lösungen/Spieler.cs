using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche4.Übungen.Lösungen
{
    internal class Spieler
    {

        // Instanzvariablen für die Klasse Spieler
        public string Name;
        public int Punkte;
        public string Team;

        // Konstruktor zur Initialisierung der Spielerdaten
        public Spieler(string name, int punkte, string team)
        {
            this.Name = name;
            this.Punkte = punkte;
            this.Team = team;
        }

        // Main-Methode zum Testen der Klasse
        static void Main(string[] args)
        {
            // Instanz der Klasse Spieler erstellen
            Spieler spieler1 = new Spieler("Mario", 42, "Blaues Team");

            // Ausgabe der Spielerinformationen
            Console.WriteLine($"Spieler: {spieler1.Name}, Punkte: {spieler1.Punkte}, Team: {spieler1.Team}");
            Console.ReadLine();
        }

    }
}
