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
            string strOperator = GetUserInput("Operator (+, -, /, *) eingeben: ");

            // Eingabestring in Zahlen umwandeln
            // TODO: Später in eigene Methode auslagern
            double firstNumberInput = Convert.ToDouble(strFirstNumber);
            double secondNumberInput = Convert.ToDouble(strSecondNumber);

            double result = Calculate(firstNumberInput, secondNumberInput, strOperator);
            GenerateOutput(result, strOperator);
        }

        static string GetUserInput(string inputText)
                {
                    Console.Write(inputText);
                    string strNumber = Console.ReadLine();
                    return strNumber;
                }

        static double Calculate(double firstNumber, double secondNumber, string strOperator)
        {
            double result =0;
            switch (strOperator)
            {
                case "+":
                    result = AddNumbers(firstNumber, secondNumber);
                    break;

                case "-":
                    result = SubtractNumbers(firstNumber, secondNumber);
                    break;

                case "/":
                    result = DivideNumbers(firstNumber, secondNumber);
                    break;

                case "*":
                    result = MultiplyNumbers(firstNumber, secondNumber);
                    break;
            }
            return result;
        }

        static void GenerateOutput(double result, string strOperator)
        {
            switch (strOperator)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0:F}", result);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0:F}", result);
                    break;

                case "/":
                    if (result != 0)
                    {
                        Console.WriteLine("Der Quotient ist: {0:F}", result);
                    }
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist: {0:F}", result);
                    break;

                default:
                    Console.WriteLine("Ungültiger Operator!");
                    break;
            }

            GetUserInput("Zum Beenden bitte die Enter-Taste drücken");
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

        static double DivideNumbers(double dividend, double divisor)
        {
            double quotient = 0;
            if (divisor != 0)
            {
                quotient = dividend / divisor;
            }
            else
            {
                Console.WriteLine("Ungültiger Divisor!");
            }
            return quotient;
        }

        static double MultiplyNumbers(double firstNumber, double secondNumber)
        {
            double product = firstNumber * secondNumber;
            return product;
        }
    }
}
