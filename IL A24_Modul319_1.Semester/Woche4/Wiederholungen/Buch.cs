using System; // Importiert die System-Bibliothek

namespace IL_A24_Modul319_1.Semester.Woche4.Wiederholungen  // Definiert den Namensraum
{
    // Eine einfache Klasse "Buch", die ein Buch repräsentiert.
    class Buch
    {
        // Instanzvariablen für die Klasse "Buch"
        public string Titel;    // Speichert den Titel des Buches
        public string Autor;    // Speichert den Autor des Buches
        public int Seitenanzahl; // Speichert die Anzahl der Seiten im Buch

        // Konstruktor, um eine neue Instanz der Klasse "Buch" zu initialisieren
        public Buch(string titel, string autor, int seitenanzahl)
        {
            this.Titel = titel;        // Initialisiert die Instanzvariable "Titel"
            this.Autor = autor;        // Initialisiert die Instanzvariable "Autor"
            this.Seitenanzahl = seitenanzahl; // Initialisiert die Instanzvariable "Seitenanzahl"
        }

        // Main-Methode, um die Klasse zu testen
        static void Main(string[] args)
        {
            // Erstellen einer neuen Instanz der Klasse "Buch"
            Buch buch1 = new Buch("Der Herr der Ringe", "J.R.R. Tolkien", 1216);

            // Ausgabe der Buchinformationen auf der Konsole
            Console.WriteLine($"Buch: {buch1.Titel}, Autor: {buch1.Autor}, Seitenanzahl: {buch1.Seitenanzahl}");

            // Programm pausiert bis zum Drücken einer Taste
            Console.ReadLine();
        }
    }
}
