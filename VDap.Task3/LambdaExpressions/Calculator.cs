using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.LambdaExpressions
{
    public delegate double AddNumber(double number1, double numb2);
    public delegate double SubtractNumber(double number1, double numb2);
    public delegate double MultiplyNumber(double number1, double numb2);
    public delegate double DivideNumber(double number1, double numb2);
    public delegate bool EvenOrOdd(int number);
    public static class Calculator
    {
        public static AddNumber Add = (double num1, double num2) =>
        {
            return num1 + num2;
        };
        public static SubtractNumber Subtract = (double num1, double num2) =>
        {
            return num1 - num2;
        };
        public static MultiplyNumber Multiply = (double num1, double num2) =>
        {
            return num1 * num2;
        };
        public static DivideNumber Divide = (double num1, double num2) =>
        {
            return (num1 / num2);
        };
        public static EvenOrOdd IsEven = (int number) =>
        {
            if (number % 2 == 0)
                return true;
            return false;
        };
    }
}
