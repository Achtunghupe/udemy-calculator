using System;


namespace udemy_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ziel: Zwei Ganzzahlen addieren
            Console.Write("Erste Zahl eingeben: ");
            string strFirstNumber = Console.ReadLine();
            Console.Write("Zweite Zahl eingeben: ");
            string strSecondNumber = Console.ReadLine();

            // Eingabestring in Zahlen umwandeln
            int intFirstNumber = Convert.ToInt32(strFirstNumber);
            int intSecondNumber = Convert.ToInt32(strSecondNumber);

            // Berechnung und Ausgabe
            int sum = intFirstNumber + intSecondNumber;
            Console.WriteLine("Das Ergebnis ist: {0}", sum);
            Console.ReadLine();
        }
    }
}
