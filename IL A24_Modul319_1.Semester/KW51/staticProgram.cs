using System;

class GreetingHelper
{
    // Statische Methode, um eine Begrüssung anzuzeigen
    public static void DisplayGreeting(string name)
    {
        Console.WriteLine($"Hallo, {name}! Willkommen!");
    }
}

class staticProgram
{
    static void Main(string[] args)
    {
        // Aufrufen der statischen Methode ohne ein Objekt zu erstellen
        GreetingHelper.DisplayGreeting("Max");

        GreetingHelper.DisplayGreeting("Anna");
    }
}
/*
Eine statische Methode in C# gehört zur Klasse selbst und nicht zu einer bestimmten Instanz dieser Klasse.
Das bedeutet, dass du eine statische Methode direkt über den Klassennamen aufrufen kannst,
ohne vorher ein Objekt der Klasse zu erstellen. Statische Methoden werden mit dem Schlüsselwort static definiert.

Statische Methoden sind besonders nützlich, wenn eine Funktion unabhängig von den Eigenschaften
oder dem Zustand eines Objekts ausgeführt werden kann. Beispiele sind allgemeine Hilfsfunktionen,
wie Berechnungen, Validierungen oder das Anzeigen von Nachrichten. Da sie zur Klasse gehören,
können sie nur auf andere statische Mitglieder der Klasse zugreifen, nicht auf Instanzvariablen oder -methoden.

Beispiel: Eine Klasse GreetingHelper kann eine statische Methode DisplayGreeting haben,
die eine Begrüssung ausgibt. Diese Methode benötigt keine spezifischen Daten einer Instanz,
sondern arbeitet nur mit den übergebenen Parametern. Du kannst sie direkt mit GreetingHelper.DisplayGreeting("Max") aufrufen.

Statische Methoden machen den Code klarer und sparen Speicher, da keine Objekte erstellt werden müssen.
Sie eignen sich für Funktionen, die unabhängig von Objekten sind, wie z. B. Console.WriteLine(),
die auch eine statische Methode ist.
*/