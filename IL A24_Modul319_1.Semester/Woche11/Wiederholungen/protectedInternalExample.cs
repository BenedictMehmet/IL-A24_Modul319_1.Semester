using IL_A24_Modul319_1.Semester.Woche4.Wiederholungen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche11.Wiederholungen
{
    class protectedInternalExample
    {
        // Ein 'protected internal' Mitglied
        protected internal string geschützterText = "Ich bin ein geschütztes internes Mitglied.";

        // Methode, um den Text zu ändern
        protected internal void ZeigeText()
        {
            Console.WriteLine(geschützterText);
        }
    }

    // Abgeleitete Klasse, die auf das 'protected internal'-Mitglied zugreift
    class DerivedClass : protectedInternalExample
    {
        public void ÄndereText(string neuerText)
        {
            // Zugriff auf das 'protected internal'-Mitglied der Basisklasse
            geschützterText = neuerText;
        }
    }

    // Hauptklasse mit der Main-Methode
    class protectedInternalProgramm
    {
        static void Main(string[] args)
        {
            // Objekt der Basisklasse erstellen
            protectedInternalExample baseObj = new protectedInternalExample();

            // Zugriff auf die 'protected internal'-Methode innerhalb derselben Assembly
            baseObj.ZeigeText(); // Ausgabe: "Ich bin ein geschütztes internes Mitglied."

            // Objekt der abgeleiteten Klasse erstellen
            DerivedClass derivedObj = new DerivedClass();

            // Abgeleitete Klasse kann den Text ändern
            derivedObj.ÄndereText("Neuer Text aus der abgeleiteten Klasse.");
            derivedObj.ZeigeText(); // Ausgabe: "Neuer Text aus der abgeleiteten Klasse."

            // Innerhalb derselben Assembly können auch Nicht-abgeleitete Klassen auf 'protected internal' zugreifen:
            baseObj.geschützterText = "Text aus der Main-Methode geändert.";
            baseObj.ZeigeText(); // Ausgabe: "Text aus der Main-Methode geändert."
        }
    }
}

/*
Was ist protected internal in C#?
Der Zugriffsmodifizierer protected internal kombiniert die Eigenschaften von protected und internal.
Mitglieder, die als protected internal deklariert sind, können von:

Innerhalb der eigenen Assembly(wie internal).
Abgeleiteten Klassen(wie protected), auch wenn sie sich in einer anderen Assembly befinden.
Das bedeutet, dass ein protected internal -Mitglied von allen Klassen innerhalb derselben Assembly und
von abgeleiteten Klassen in anderen Assemblies zugänglich ist.
Es erweitert den Zugriff von protected auf die Assembly hinaus und erlaubt dennoch den Einsatz in Vererbungsszenarien.

Wozu wird protected internal verwendet?
protected internal wird verwendet, wenn Sie eine Klasse oder ein Mitglied in zwei Szenarien zugänglich machen möchten:

Es soll innerhalb derselben Assembly von beliebigen Klassen genutzt werden können.
Es soll zusätzlich von abgeleiteten Klassen, die sich in einer anderen Assembly befinden, zugänglich sein.
Das ist nützlich, wenn Sie Teile einer Klasse sowohl für Vererbung als auch für interne Zusammenarbeit
innerhalb eines Projekts offenlegen möchten, ohne sie komplett öffentlich (public) zu machen.
*/