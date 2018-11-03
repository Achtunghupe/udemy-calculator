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
            double firstNumber = Convert.ToDouble(strFirstNumber);
            double secondNumber = Convert.ToDouble(strSecondNumber);

            // Berechnung und Ausgabe
            double sum = firstNumber + secondNumber;
            Console.WriteLine("Das Ergebnis ist: {0:F}", sum);
            Console.ReadLine();

        }
    }
}
