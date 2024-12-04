using System;

namespace IL_A24_Modul319_1.Semester.Woche11.Wiederholungen
{
    class protectedExample
    {
        // Geschützte Variable
        protected int zahl = 20;

        // Geschützte Methode
        protected void ZeigeZahl()
        {
            Console.WriteLine("Die geschützte Zahl ist: " + zahl);
        }

        // Öffentliche Methode, die Zugriff auf geschützte Mitglieder gibt
        public void ZugriffAufProtected()
        {
            Console.WriteLine("Zugriff auf die geschützten Mitglieder innerhalb derselben Klasse:");
            ZeigeZahl(); // ✅ Geschützte Methode aufrufen
        }
    }

    class protectedProgramm
    {
        static void Main(string[] args)
        {
            // Objekt der Klasse erstellen
            protectedExample example = new protectedExample();

            // Direkter Zugriff auf geschützte Mitglieder ist nicht möglich:
            // example.zahl = 30; // ❌ Fehler: 'zahl' ist geschützt
            // example.ZeigeZahl(); // ❌ Fehler: 'ZeigeZahl' ist geschützt

            // Zugriff über eine öffentliche Methode, die intern geschützte Mitglieder verwendet:
            example.ZugriffAufProtected(); // ✅ Funktioniert
        }
    }
}

/*
Was ist protected in C#?
Der Zugriffsmodifizierer protected wird in C# verwendet,
um den Zugriff auf Klassenmitglieder (z. B. Variablen oder Methoden) einzuschränken. Mitglieder,
die als protected deklariert sind, sind nur innerhalb der Klasse,
in der sie definiert wurden, und in abgeleiteten Klassen
(Klassen, die von der Basisklasse erben) zugänglich. Im Gegensatz zu private,
das den Zugriff vollständig auf die eigene Klasse beschränkt,
erlaubt protected den Zugriff innerhalb einer Vererbungshierarchie.
Dies macht protected ideal für Situationen,
in denen eine Basisklasse bestimmte Daten oder Logik mit abgeleiteten Klassen teilen möchte,
ohne diese Daten oder Methoden der Aussenwelt zugänglich zu machen.

Wozu wird protected verwendet?
protected wird verwendet, um Daten und Methoden in einer Basisklasse vor unbefugtem Zugriff
zu schützen und gleichzeitig die Wiederverwendbarkeit durch Vererbung zu ermöglichen.
Es ist besonders nützlich in Szenarien, in denen abgeleitete Klassen die Implementierung
der Basisklasse erweitern oder anpassen sollen. Zum Beispiel kann eine Basisklasse allgemeine
Logik bereitstellen (z. B. Berechnungsmethoden oder Statusvariablen), die von spezialisierten
abgeleiteten Klassen genutzt werden können. Dabei bleiben die protected-Mitglieder vor direktem
Zugriff durch andere Teile des Programms geschützt, was die Integrität und Sicherheit der Klasse gewährleistet.

Abgeleitete Klassen werden wir in den nächsten Wochen noch anschauen!

*/