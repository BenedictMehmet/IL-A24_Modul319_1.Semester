using System; // Importiert das System-Namespace,
              //das grundlegende Klassen und Funktionen
              //für die Arbeit mit der Konsole bereitstellt.

namespace IL_A24_Modul319_1.Semester.Woche4.Wiederholungen // Definiert einen Namensraum,
                                                           // um die Anwendung zu organisieren und Namenskonflikte zu vermeiden.
{
    // Dies ist die Definition der Klasse "Person"
    // Klassen in C# dienen als Blaupausen für Objekte und können Eigenschaften und Methoden enthalten.
    internal class Person
    {

        // Instanzvariablen (auch Felder genannt) für die Klasse "Person".
        // Diese Variablen sind spezifisch für jedes Objekt (jede Instanz), das von der Klasse "Person" erstellt wird.
        public string Vorname;   // Die Variable "Vorname" speichert den Vornamen der Person.
        public string Nachname;  // Die Variable "Nachname" speichert den Nachnamen der Person.
        public int Alter;        // Die Variable "Alter" speichert das Alter der Person als Ganzzahl (int).

        // Dies ist der Konstruktor der Klasse "Person".
        // Ein Konstruktor ist eine spezielle Methode, die aufgerufen wird, wenn eine neue Instanz (ein Objekt) der Klasse erstellt wird.
        // Der Konstruktor nimmt Parameter entgegen und initialisiert die Instanzvariablen mit den übergebenen Werten.
        public Person(string vorname, string nachname, int alter)
        {
            // "this.Vorname" bezieht sich auf die Instanzvariable "Vorname" der Klasse.
            // Die Zuweisung weist dem Feld "Vorname" den Wert des Parameters "vorname" zu.
            this.Vorname = vorname;  // Initialisiert die Instanzvariable "Vorname" mit dem übergebenen Parameter "vorname".

            this.Nachname = nachname;  // Initialisiert die Instanzvariable "Nachname" mit dem übergebenen Parameter "nachname".

            this.Alter = alter;  // Initialisiert die Instanzvariable "Alter" mit dem übergebenen Parameter "alter".
        }

        // Die "Main"-Methode ist der Einstiegspunkt des Programms.
        // Jedes C#-Programm benötigt eine "Main"-Methode,
        // die als erste Methode beim Start des Programms ausgeführt wird.
        static void Main(string[] args)
        {
            // Hier wird eine Instanz der Klasse "Person" erstellt.
            // Der Konstruktor wird aufgerufen, und die Werte "Max",
            // "Mustermann" und 25 werden als Argumente übergeben.

            // Diese Argumente initialisieren die Instanzvariablen
            // "Vorname", "Nachname" und "Alter" für das Objekt "person1".
            Person person1 = new Person("Max", "Mustermann", 25);

            // Ausgabe der Informationen der Person auf der Konsole.
            // Die geschweiften Klammern in einem Zeichenfolgenliteral ($" ... ")
            // ermöglichen die Einbettung von Variablenwerten direkt im Text.
            Console.WriteLine($"Name: {person1.Vorname} {person1.Nachname}, Alter: {person1.Alter}");

            // "Console.ReadLine()" hält das Programm an, bis der Benutzer eine Eingabetaste drückt.
            // Dies wird verwendet, damit das Konsolenfenster nicht sofort nach der Ausgabe schliesst.
            Console.ReadLine();
        }
    }
}

