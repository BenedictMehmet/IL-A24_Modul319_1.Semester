using System;

namespace IL_A24_Modul319_1.Semester.Woche11.Wiederholungen
{
    // Klasse mit privaten Mitgliedern
    class PrivateExample
    {
        // Private Variable
        private int zahl = 10;

        // Private Methode
        private void ZeigeZahl()
        {
            Console.WriteLine("Die private Zahl ist: " + zahl);
        }

        // Öffentliche Methode, die Zugriff auf private Mitglieder gibt. Ohne diese Methode, könnte kein Zugriff gewährt werden.
        public void TestPrivateZugriff()
        {
            Console.WriteLine("Aufruf der privaten Methode durch eine öffentliche Methode:");
            ZeigeZahl(); // ✅ Zugriff innerhalb derselben Klasse
        }
    }

    // Klasse mit der Main-Methode
    class privateProgamm
    {
        static void Main(string[] args)
        {
            // Objekt der Klasse `PrivateExample` erstellen
            PrivateExample beispiel = new PrivateExample();

            // Direkter Zugriff auf private Mitglieder ist nicht möglich:
            // beispiel.zahl = 20; // ❌ Fehler: 'zahl' ist privat
            // beispiel.ZeigeZahl(); // ❌ Fehler: 'ZeigeZahl' ist privat

            // Zugriff über eine öffentliche Methode, die private Mitglieder verwendet:
            beispiel.TestPrivateZugriff(); // ✅ Funktioniert
           
        }
    }
}

/*
Was ist private?
Der Zugriffsmodifizierer private in C# ist eine Möglichkeit, den Zugriff auf bestimmte Elemente
(z. B. Variablen oder Methoden) nur auf die Klasse zu beschränken, in der sie definiert wurden.
Das bedeutet, dass kein anderes Objekt, keine andere Klasse oder kein anderer Codeblock ausserhalb
der Klasse direkt auf diese Elemente zugreifen kann. private ist der restriktivste Zugriffsmodifizierer in C#.
Es wird standardmässig für Klassenmitglieder verwendet, wenn kein anderer Modifizierer angegeben wird.
Mit private können Sie verhindern, dass Daten von aussen geändert oder verwendet werden.

Wozu wird private verwendet?
private wird verwendet, um die Datenkapselung (Encapsulation) zu fördern,
ein Grundprinzip der objektorientierten Programmierung.
Es schützt sensible Daten oder interne Logik vor direktem Zugriff und Manipulation.
Stattdessen kann die Klasse den Zugriff über öffentliche Methoden (Getter/Setter) kontrollieren.
Dadurch wird sichergestellt,
dass die Datenintegrität erhalten bleibt und die interne Implementierung der Klasse flexibel geändert werden kann,
ohne andere Teile des Codes zu beeinflussen.
Es hilft auch, Fehler zu vermeiden, indem versehentliche Änderungen von ausserhalb verhindert werden.
Kurz gesagt, private sorgt für mehr Sicherheit, Wartbarkeit und Klarheit im Code.

*/