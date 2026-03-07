using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using CalculatorApp;
using System.Threading.Tasks;


namespace TestProject1
{
    internal class CalculatorTests
    {
        private Calculator calc;
        [Test]
        public void Add_TwoNumbers_ReturnSum()
        {
            //Arrange
            int a = 5, b = 6;
            //Act
            int result = calc.add(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(11));
        }

        public void Subtract_TwoNumbers_ReturnDifference()
        {
            //Arrange
            int a = 11, b = 6;
            //Act
            int result = calc.subtract(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(5));
        }

        public void Multiply_TwoNumbers_ReturnMultiplication()
        {
            //Arrange
            int a = 5, b = 6;
            //Act
            int result = calc.multiply(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(30));
        }

        public void Divide_TwoNumbers_ReturnQuotient()
        {
            //Arrange
            double a = 50.0, b = 5.0;
            //Act
            double result = calc.divide(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(10.0));
        }
    }
}
