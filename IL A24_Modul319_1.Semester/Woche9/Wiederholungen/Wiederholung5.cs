using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche9.Wiederholungen
{
    internal class Wiederholung5
    {
        class Person
        {
            public string Name { get; set; }
            public int Alter { get; set; }
        }

        static void Main()
        {
            // Erstellen einer Liste von Personen
            List<Person> personen = new List<Person>
        {
            new Person { Name = "Max", Alter = 30 },
            new Person { Name = "Lena", Alter = 25 },
            new Person { Name = "Tom", Alter = 35 }
        };

            // foreach-Schleife: Iteriert über jede Person in der Liste
            foreach (Person person in personen)
            {
                // Ausgabe der Eigenschaften der aktuellen Person
                Console.WriteLine($"Name: {person.Name}, Alter: {person.Alter}");
            }
        }
    }
}
