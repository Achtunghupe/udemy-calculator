using System;


namespace udemy_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ziel: Zwei Gleitkommazahlen addieren
            string strFirstNumber = GetNumber("Erste Zahl eingeben: ");
            string strSecondNumber = GetNumber("Zweite Zahl eingeben: ");

            // Eingabestring in Zahlen umwandeln
            double firstNumberInput = ConvertNumber(strFirstNumber);
            double secondNumberInput = ConvertNumber(strSecondNumber);

            // Berechnung und Ausgabe
            double sum = AddNumbers(firstNumberInput, secondNumberInput);
            Console.WriteLine("Das Ergebnis ist: {0:F}", sum);
            WaitEndOfProgram();

        }

        static string GetNumber(string inputText)
        {
            Console.Write(inputText);
            string strNumber = Console.ReadLine();
            return strNumber;
        }

        static double ConvertNumber (string Number)
        {
            double convertedNumber = Convert.ToDouble(Number);
            return convertedNumber;
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
