using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{

    public class Calculators
    {
        public int Add(int a, int b) => a + b;


        public int Substract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero");
            return (double)a / b;
        }

    }
}
