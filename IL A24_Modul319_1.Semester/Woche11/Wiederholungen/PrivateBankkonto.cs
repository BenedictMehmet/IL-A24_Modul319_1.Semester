using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche11.Wiederholungen
{
    // Klasse, die ein Bankkonto repräsentiert
    class Bankkonto
    {
        // Private Variable, die den Kontostand speichert
        private decimal kontostand;

        // Konstruktor: Initialisiert das Bankkonto mit einem Anfangsguthaben
        public Bankkonto(decimal startguthaben)
        {
            kontostand = startguthaben; // Zugriff auf die private Variable innerhalb der Klasse
        }

        // Öffentliche Methode: Gibt den aktuellen Kontostand zurück
        public decimal KontostandAbfragen()
        {
            return kontostand; // Kontrollierter Zugriff auf die private Variable
        }

        // Öffentliche Methode: Erlaubt eine Einzahlung
        public void Einzahlung(decimal betrag)
        {
            if (betrag > 0) // Validierung, dass der Betrag positiv ist
            {
                kontostand += betrag; // Aktualisierung der privaten Variable
                Console.WriteLine($"Sie haben {betrag:C} eingezahlt. Neuer Kontostand: {kontostand:C}");
            }
            else
            {
                Console.WriteLine("Der Einzahlungsbetrag muss positiv sein!");
            }
        }

        // Öffentliche Methode: Erlaubt eine Auszahlung
        public void Auszahlung(decimal betrag)
        {
            if (betrag > 0 && betrag <= kontostand) // Validierung: Betrag muss positiv und verfügbar sein
            {
                kontostand -= betrag; // Aktualisierung der privaten Variable
                Console.WriteLine($"Sie haben {betrag:C} abgehoben. Neuer Kontostand: {kontostand:C}");
            }
            else
            {
                Console.WriteLine("Ungültiger Abhebungsbetrag! Stellen Sie sicher, dass genügend Guthaben vorhanden ist.");
            }
        }
    }

    // Klasse mit der Main-Methode (Einstiegspunkt)
    class privateBankkonto
    {
        static void Main(string[] args)
        {
            // Ein neues Bankkonto mit einem Anfangsguthaben von 1000 Euro erstellen
            Bankkonto konto = new Bankkonto(1000);

            // Kontostand abfragen
            Console.WriteLine($"Aktueller Kontostand: {konto.KontostandAbfragen():C}");

            // Geld einzahlen
            konto.Einzahlung(500);

            // Geld abheben
            konto.Auszahlung(300);

            // Ungültiger Einzahlungsbetrag
            konto.Einzahlung(-100);

            // Ungültiger Abhebungsbetrag
            konto.Auszahlung(2000);
        }
    }
}
