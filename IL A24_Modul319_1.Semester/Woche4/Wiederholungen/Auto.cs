using System; // Importiert die System-Bibliothek

namespace IL_A24_Modul319_1.Semester.Woche4.Wiederholungen // Definiert den Namensraum
{
    // Eine einfache Klasse "Auto", die ein Fahrzeug repräsentiert.
    class Auto
    {
        // Instanzvariablen für die Klasse "Auto"
        public string Marke;    // Speichert die Marke des Autos (z. B. BMW, Audi)
        public string Modell;   // Speichert das Modell des Autos (z. B. X5, A4)
        public int Baujahr;     // Speichert das Baujahr des Autos

        // Konstruktor, um eine neue Instanz der Klasse "Auto" zu initialisieren
        public Auto(string marke, string modell, int baujahr)
        {
            this.Marke = marke;   // Initialisiert die Instanzvariable "Marke"
            this.Modell = modell; // Initialisiert die Instanzvariable "Modell"
            this.Baujahr = baujahr; // Initialisiert die Instanzvariable "Baujahr"
        }

        // Main-Methode, um die Klasse zu testen
        static void Main(string[] args)
        {
            // Erstellen einer neuen Instanz der Klasse "Auto"
            Auto auto1 = new Auto("BMW", "X5", 2020);

            // Ausgabe der Autoinformationen auf der Konsole
            Console.WriteLine($"Auto: {auto1.Marke} {auto1.Modell}, Baujahr: {auto1.Baujahr}");

            // Programm pausiert bis zum Drücken einer Taste
            Console.ReadLine();
        }
    }
}

