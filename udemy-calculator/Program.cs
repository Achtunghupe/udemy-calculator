using System;


namespace udemy_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ziel: Zwei Gleitkommazahlen addieren
            Console.Write("Erste Zahl eingeben: ");
            string strFirstNumber = Console.ReadLine();
            Console.Write("Zweite Zahl eingeben: ");
            string strSecondNumber = Console.ReadLine();

            // Eingabestring in Zahlen umwandeln
            float floatFirstNumber = Convert.ToSingle(strFirstNumber);
            float floatSecondNumber = Convert.ToSingle(strSecondNumber);

            // Berechnung und Ausgabe
            float sum = floatFirstNumber + floatSecondNumber;
            Console.WriteLine("Das Ergebnis ist: {0:F}", sum);
            Console.ReadLine();
        }
    }
}
