using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{
    public class Calculator
    {
        public int add(int a, int b) => a + b;
        public int subtract(int a, int b) => a - b;
        public int multiply(int a, int b) => a * b;
        public double divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero");
            return (double)a / b;

        }
        

    }
}
