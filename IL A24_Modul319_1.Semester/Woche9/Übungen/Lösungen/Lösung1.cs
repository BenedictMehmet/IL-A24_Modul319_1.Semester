using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche9.Übungen.Lösungen
{
    internal class Lösung1
    {
        static void Main()
        {
            // Einlesen der ersten Zahl
            Console.Write("Geben Sie die erste Zahl ein: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            // Einlesen der zweiten Zahl
            Console.Write("Geben Sie die zweite Zahl ein: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            // Einlesen der gewünschten Operation
            Console.Write("Geben Sie die Operation ein (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Für eine neue Zeile nach der Eingabe

            // Berechnung basierend auf der eingegebenen Operation
            double ergebnis = 0;
            switch (operation)
            {
                case '+':
                    ergebnis = zahl1 + zahl2;
                    break;
                case '-':
                    ergebnis = zahl1 - zahl2;
                    break;
                case '*':
                    ergebnis = zahl1 * zahl2;
                    break;
                case '/':
                    if (zahl2 != 0)
                    {
                        ergebnis = zahl1 / zahl2;
                    }
                    else
                    {
                        Console.WriteLine("Fehler: Division durch Null ist nicht erlaubt.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Ungültige Operation.");
                    return;
            }

            // Ausgabe des Ergebnisses
            Console.WriteLine($"Ergebnis: {zahl1} {operation} {zahl2} = {ergebnis}");
        }
    }
}
