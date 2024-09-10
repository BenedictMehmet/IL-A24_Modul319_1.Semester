using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche4.Übungen.Lösungen
{
    internal class Produkt
    {

        // Instanzvariablen für die Klasse Produkt
        public string Name;
        public double Preis;
        public int Menge;

        // Konstruktor zur Initialisierung der Produktdaten
        public Produkt(string name, double preis, int menge)
        {
            this.Name = name;
            this.Preis = preis;
            this.Menge = menge;
        }

        // Main-Methode zum Testen der Klasse
        static void Main(string[] args)
        {
            // Instanz der Klasse Produkt erstellen
            Produkt produkt1 = new Produkt("Laptop", 899.99, 5);

            // Ausgabe der Produktinformationen
            Console.WriteLine($"Produkt: {produkt1.Name}, Preis: {produkt1.Preis}€, Menge: {produkt1.Menge} Stück");
            Console.ReadLine();
        }

    }
}
