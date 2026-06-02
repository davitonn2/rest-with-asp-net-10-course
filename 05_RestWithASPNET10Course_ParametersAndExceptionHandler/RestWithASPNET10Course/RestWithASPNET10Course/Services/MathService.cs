namespace RestWithASPNET10Course.Services
{
    public class MathService
    {
        public decimal Sum(decimal firstNumber, decimal secondNumber) => firstNumber + secondNumber;
        public decimal Subtraction(decimal firstNumber, decimal secondNumber) => firstNumber - secondNumber;
        public decimal Multiplication(decimal firstNumber, decimal secondNumber) => firstNumber * secondNumber;
        public decimal Division(decimal firstNumber, decimal secondNumber)
        {
            if (secondNumber == 0) throw new DivideByZeroException("Division by zero is not allowed.");
            return firstNumber / secondNumber;
        }
        public decimal Mean(decimal firstNumber, decimal secondNumber) => (firstNumber + secondNumber) / 2;
        public decimal SquareRoot(decimal number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException("Square root of a negative number is not defined.");
            return (decimal)Math.Sqrt((double)number);
        }
    }
}
