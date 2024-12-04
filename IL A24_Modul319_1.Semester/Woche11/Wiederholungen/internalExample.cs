using IL_A24_Modul319_1.Semester.Woche10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche11.Wiederholungen
{
    internal class internalExample
    {
        static void Main (string[] args)
        {
            GotoExample1.LoopWithGoto();
        }

       

        
    }
}



/*
Was ist internal in C#?
Der Zugriffsmodifizierer internal erlaubt den Zugriff auf Klassen, Methoden,
oder Variablen nur innerhalb derselben Assembly (in der Regel innerhalb desselben Projekts).
Mitglieder, die als internal deklariert sind, können von jeder Klasse innerhalb der gleichen Assembly genutzt werden,
sind aber von ausserhalb der Assembly nicht zugänglich. Das bedeutet, dass internal ideal für Szenarien ist,
in denen Klassen oder Methoden für andere Klassen im selben Projekt zugänglich sein sollen,
aber vor Zugriffen aus anderen Projekten geschützt werden sollen.

Wozu wird internal verwendet?
internal wird verwendet, um eine klare Trennung zwischen öffentlichen Schnittstellen (z. B. APIs)
und internen Implementierungsdetails innerhalb eines Projekts zu schaffen. Es erlaubt, dass Klassen und
Methoden von anderen Klassen innerhalb derselben Assembly genutzt werden können,
ohne dass sie öffentlich zugänglich gemacht werden müssen. Dies erhöht die Sicherheit und Kapselung,
da externe Assemblies keine Möglichkeit haben, auf interne Details zuzugreifen.
Es ist besonders nützlich, wenn verschiedene Teile eines Projekts zusammenarbeiten müssen,
aber nicht von externen Abhängigkeiten beeinflusst werden sollen.

Das machen wir im Moment schon die ganze Zeit. Wir haben ein Projekt erstellt und können hiermit auf andere Klassen
zugreifen
*/