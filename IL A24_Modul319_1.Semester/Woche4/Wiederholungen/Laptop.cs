using System; // Importiert die System-Bibliothek

namespace IL_A24_Modul319_1.Semester.Woche4.Wiederholungen  // Definiert den Namensraum
{
    // Eine einfache Klasse "Laptop", die ein Laptop repräsentiert.
    class Laptop
    {
        // Instanzvariablen für die Klasse "Laptop"
        public string Marke;      // Speichert die Marke des Laptops
        public string Prozessor;  // Speichert den Prozessor des Laptops
        public int RAM;           // Speichert die RAM-Grösse in GB

        // Konstruktor, um eine neue Instanz der Klasse "Laptop" zu initialisieren
        public Laptop(string marke, string prozessor, int ram)
        {
            this.Marke = marke;          // Initialisiert die Instanzvariable "Marke"
            this.Prozessor = prozessor;  // Initialisiert die Instanzvariable "Prozessor"
            this.RAM = ram;              // Initialisiert die Instanzvariable "RAM"
        }

        // Main-Methode, um die Klasse zu testen
        static void Main(string[] args)
        {
            // Erstellen einer neuen Instanz der Klasse "Laptop"
            Laptop laptop1 = new Laptop("Apple", "M1", 16);

            // Ausgabe der Laptopinformationen auf der Konsole
            Console.WriteLine($"Laptop: {laptop1.Marke}, Prozessor: {laptop1.Prozessor}, RAM: {laptop1.RAM}GB");

            // Programm pausiert bis zum Drücken einer Taste
            Console.ReadLine();
        }
    }
}

