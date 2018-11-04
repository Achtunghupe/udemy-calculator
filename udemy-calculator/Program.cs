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
            double firstNumberInput = Convert.ToDouble(strFirstNumber);
            double secondNumberInput = Convert.ToDouble(strSecondNumber);

            // Berechnung und Ausgabe
            double sum = AddNumbers(firstNumberInput, secondNumberInput);
            Console.WriteLine("Das Ergebnis ist: {0:F}", sum);
            WaitEndOfProgram();

        }

        static double AddNumbers(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            return sum;
        }

        static void WaitEndOfProgram()
        {
            Console.WriteLine("Zum Beenden bitte die Enter-Taste drücken");
            Console.ReadLine();
        }
    }
}
