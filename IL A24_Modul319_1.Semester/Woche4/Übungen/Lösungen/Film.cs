using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche4.Übungen.Lösungen
{
    internal class Film
    {
        // Instanzvariablen für die Klasse Film
        public string Titel;
        public string Regisseur;
        public int Dauer;

        // Konstruktor zur Initialisierung der Filmdaten
        public Film(string titel, string regisseur, int dauer)
        {
            this.Titel = titel;
            this.Regisseur = regisseur;
            this.Dauer = dauer;
        }

        // Main-Methode für die Ausgabe
        static void Main(string[] args)
        {
            // Instanz der Klasse Film erstellen
            Film film1 = new Film("Inception", "Christopher Nolan", 148);

            // Ausgabe der Filminformationen
            Console.WriteLine($"Film: {film1.Titel}, Regisseur: {film1.Regisseur}, Dauer: {film1.Dauer} Minuten");
            Console.ReadLine();
        }


    }
}
