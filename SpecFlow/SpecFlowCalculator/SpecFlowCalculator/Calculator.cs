using System.Diagnostics.CodeAnalysis;

namespace SpecFlowCalculator
{
    public  class Calculator
    {
        public static float FirstNumber { get; set; }
        public static float SecondNumber { get; set; }

        public static float Add(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            float result = FirstNumber + SecondNumber;
            
            return result;
        }

        public static float Substract(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            float result = FirstNumber - SecondNumber;
            return result;
        }

        public static float Divide(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            float result = FirstNumber / SecondNumber;
            return result;
        }

        public static float Multiply(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            float result = FirstNumber * SecondNumber;
            return result;
        }

    }
}