using System;

// Definition der abstrakten Klasse "Device"
abstract class Device
{
    // Abstrakte Methode: Muss in abgeleiteten Klassen implementiert werden
    public abstract void TurnOn();
}

// Abgeleitete Klasse "Phone"
class Phone : Device
{
    // Implementierung der abstrakten Methode
    public override void TurnOn()
    {
        Console.WriteLine("Das Telefon schaltet sich ein.");
    }
}

// Hauptprogramm
class phoneProgram
{
    static void Main(string[] args)
    {
        // Erstellen eines Geräts vom Typ Phone
        Device phone = new Phone();

        // Gerät einschalten
        phone.TurnOn(); // Ausgabe: Das Telefon schaltet sich ein.
    }
}

/*
Abstrakte Klasse
Eine abstrakte Klasse ist wie eine Vorlage für andere Klassen. Sie dient dazu,
gemeinsame Eigenschaften und Methoden für alle Klassen bereitzustellen,
die von ihr erben. Eine abstrakte Klasse kann sowohl Methoden enthalten,
die bereits implementiert sind (also mit Code versehen), als auch Methoden,
die nur definiert, aber noch nicht implementiert sind. Solche Methoden nennt man abstrakte Methoden,
und die abgeleiteten Klassen müssen diese Methoden implementieren.

Ein wichtiger Punkt ist, dass eine Klasse in C# nur von einer einzigen abstrakten Klasse erben kann.
Abstrakte Klassen sind also nützlich, wenn es eine enge Beziehung zwischen den Klassen gibt und sie viele Gemeinsamkeiten teilen.

Beispiel: Stell dir eine abstrakte Klasse namens „Fahrzeug“ vor.
Sie könnte Eigenschaften wie „Farbe“ und „Geschwindigkeit“ haben,
die für alle Fahrzeuge gleich sind. Die Methode „Fahren“ könnte abstrakt sein,
weil ein Auto und ein Boot unterschiedlich fahren. Beide würden diese Methode auf ihre eigene Weise umsetzen.
*/