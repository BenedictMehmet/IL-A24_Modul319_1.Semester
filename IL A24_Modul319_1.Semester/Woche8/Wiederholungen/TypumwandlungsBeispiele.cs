using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_Modul319_1.Semester.Woche8.Wiederholungen
{
    internal class TypumwandlungsBeispiele
    {

        public static void Main(string[] args)
        {
            // 1. Implizite Typumwandlung: int zu double
            int intZahl = 10; // Eine Ganzzahl
            double doubleZahl = intZahl; // Automatische Umwandlung von int zu double
            Console.WriteLine("Implizite Umwandlung von int zu double: " + doubleZahl); 

            // 2. Explizite Typumwandlung: double zu int
            doubleZahl = 9.99; // Eine Gleitkommazahl
            intZahl = (int)doubleZahl; // Explizite Umwandlung, Nachkommastellen werden abgeschnitten
            Console.WriteLine("Explizite Umwandlung von double zu int: " + intZahl); 

            // 3. String zu int mit int.Parse()
            string stringZahl = "123"; // Eine Zahl als String
            intZahl = int.Parse(stringZahl); // Umwandlung von String zu int
            Console.WriteLine("String zu int mit int.Parse(): " + intZahl); 

            // 4. String zu int mit int.TryParse() - sichere Methode
            string ungültigeZahl = "abc"; // Ungültiger String für eine Zahl
            bool erfolgreich = int.TryParse(ungültigeZahl, out intZahl); // Versuch, String in int umzuwandeln
            if (erfolgreich)
            {
                Console.WriteLine("Erfolgreiche Umwandlung: " + intZahl);
            }
            else
            {
                Console.WriteLine("Fehlgeschlagene Umwandlung mit TryParse."); 
            }

            // 5. Int zu String mit ToString()
            intZahl = 456; // Eine Ganzzahl
            stringZahl = intZahl.ToString(); // Umwandlung von int zu String
            Console.WriteLine("Int zu String mit ToString(): " + stringZahl);

            // 6. Char zu int (ASCII-Wert) (Nicht Prüfungsrelevant)
            char buchstabe = 'A'; // Ein Zeichen
            int asciiWert = buchstabe; // Umwandlung von char zu int, gibt den ASCII-Wert des Zeichens zurück
            Console.WriteLine("Char zu int (ASCII-Wert): " + asciiWert); 

            // 7. Int zu Char
            int asciiZahl = 66; // ASCII-Wert für 'B'
            buchstabe = (char)asciiZahl; // Umwandlung von int zu char
            Console.WriteLine("Int zu Char: " + buchstabe);

            // 8. String zu char (erster Buchstabe)
            string wort = "Hallo"; // Ein String
            buchstabe = wort[0]; // Zugriff auf den ersten Buchstaben des Strings
            Console.WriteLine("String zu char (erster Buchstabe): " + buchstabe);

            // 9. Umwandlung des Zeichens 'A' in eine Binärdarstellung (Nicht Prüfungsrelevant)
            char buchstabe1 = 'A'; // Das Zeichen 'A'
            string binärWert = Convert.ToString((int)buchstabe1, 2); // ASCII-Wert von 'A' wird direkt in Binär umgewandelt
            Console.WriteLine("Das Zeichen 'A' in Binär: " + binärWert);
        }

    }
}
