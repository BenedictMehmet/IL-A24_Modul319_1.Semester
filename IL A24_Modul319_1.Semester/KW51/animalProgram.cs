using System;

// Definition des Interfaces
interface IAnimal
{
    void Eat();      // Methode, die beschreibt, wie das Tier isst
    void MakeSound(); // Methode, die beschreibt, wie das Tier einen Laut von sich gibt
}

// Klasse "Dog", die das Interface IAnimal implementiert
class Dog : IAnimal
{
    // Implementierung der Methode Eat
    public void Eat()
    {
        Console.WriteLine("Der Hund isst Fleisch.");
    }

    // Implementierung der Methode MakeSound
    public void MakeSound()
    {
        Console.WriteLine("Der Hund sagt: Wuff!");
    }
}

// Klasse "Cat", die ebenfalls das Interface IAnimal implementiert
class Cat : IAnimal
{
    // Implementierung der Methode Eat
    public void Eat()
    {
        Console.WriteLine("Die Katze isst Fisch.");
    }

    // Implementierung der Methode MakeSound
    public void MakeSound()
    {
        Console.WriteLine("Die Katze sagt: Miau!");
    }
}

// Hauptprogramm
class animalProgram
{
    static void Main(string[] args)
    {
        // Eine Liste von Tieren, die das Interface IAnimal implementieren
        IAnimal[] animals = { new Dog(), new Cat() };

        // Schleife durch alle Tiere und rufe ihre Methoden auf
        foreach (IAnimal animal in animals)
        {
            animal.Eat();       // Aufruf der Eat-Methode
            animal.MakeSound(); // Aufruf der MakeSound-Methode
        }
    }
}

/*
Interface
Ein Interface ist wie ein Vertrag, der festlegt, welche Methoden oder Eigenschaften eine Klasse haben muss.
Es enthält nur die Definitionen, aber keine Implementierung der Methoden. Das bedeutet,
dass jede Klasse, die ein Interface „erfüllt“, selbst die gesamte Logik für die Methoden schreiben muss.
Interfaces können keine Felder oder Konstruktoren enthalten.

Ein grosser Vorteil von Interfaces ist, dass eine Klasse mehrere Interfaces gleichzeitig
implementieren kann. Sie sind daher besonders nützlich, wenn man möchte, dass Klassen unabhängig
voneinander denselben Vertrag einhalten, ohne dass sie verwandt sein müssen.

Beispiel: Stell dir ein Interface namens „IFliegbar“ vor. Es könnte eine Methode „Fliegen“ definieren.
Sowohl ein Vogel als auch ein Flugzeug könnten dieses Interface implementieren,
obwohl sie in der Realität und in der Programmierung völlig unterschiedliche Objekte sind.
*/