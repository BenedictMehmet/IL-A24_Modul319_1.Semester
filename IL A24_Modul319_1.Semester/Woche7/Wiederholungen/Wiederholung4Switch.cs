using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche7.Wiederholung4Switch
{
    internal class Wiederholung4Switch
    {
        static void Main()
        {
            // Eingabe der ersten Zahl
            Console.Write("Bitte geben Sie die erste Zahl ein: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            // Eingabe der zweiten Zahl
            Console.Write("Bitte geben Sie die zweite Zahl ein: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            // Eingabe der Operation (+, -, *, /)
            Console.Write("Bitte geben Sie die gewünschte Operation ein (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double ergebnis;

            // Switch-Anweisung zur Auswahl der Operation
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
                        Console.WriteLine("Division durch Null ist nicht erlaubt.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Ungültige Operation.");
                    return;
            }

            // Ausgabe des Ergebnisses
            Console.WriteLine("Das Ergebnis ist: " + ergebnis);
        }
    }



}

