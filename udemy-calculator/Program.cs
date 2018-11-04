using System;


namespace udemy_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ziel: Zwei Gleitkommazahlen addieren
            string strFirstNumber = GetUserInput("Erste Zahl eingeben: ");
            string strSecondNumber = GetUserInput("Zweite Zahl eingeben: ");
            string strOperator = GetUserInput("Operator (+, -) eingeben: ");

            // Eingabestring in Zahlen umwandeln
            double firstNumberInput = ConvertNumber(strFirstNumber);
            double secondNumberInput = ConvertNumber(strSecondNumber);

            // Berechnung und Ausgabe
            double result = 0;
            switch (strOperator)
            {
                case "+":
                    result = AddNumbers(firstNumberInput, secondNumberInput);
                    Console.WriteLine("Die Summe ist: {0:F}", result);
                    break;

                case "-":
                    result = SubtractNumbers(firstNumberInput, secondNumberInput);
                    Console.WriteLine("Die Differenz ist: {0:F}", result);
                    break;

                default:
                    Console.WriteLine("Ungültiger Operator");
                    break;
            }

            GetUserInput("Zum Beenden bitte die Enter-Taste drücken");
        }

        static string GetUserInput(string inputText)
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

        static double SubtractNumbers(double minuend, double subtrahend)
        {
            double difference = minuend - subtrahend;
            return difference;
        }
    }
}
