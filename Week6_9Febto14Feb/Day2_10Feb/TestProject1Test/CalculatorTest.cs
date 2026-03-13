using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using CalculatorApp;
using NUnit.Framework;

namespace TestProject1Test
{
    [TestFixture]
    internal class CalculatorTest
    {
        private Calculators calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculators();
        }
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            //Arrange
            int a=5, b = 3;
            int result=calc.Add(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(8));

        }
        [Test]
        public void Sustract_TwoNumbers_ReturnDiffernce()
        {
            //Arrange
            int a = 9, b = 7;
            //Act
            int result=calc.Substract(a, b);
            //Assert
            Assert.That(result,Is.EqualTo(2));


        }
        [Test]
        public void Multiply_TwoNumbers_ReturnMultiplication()
        {
            //Arrange
            int a = 3, b = 4;
            //Act
            int result = calc.Multiply(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(12));


        }
        [Test]
        public void Divide_TwoNumbers_ReturnDivision()
        {
            //Arrange
            double a = 12, b = 0;
            //Act
            double result = calc.Divide(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(4));


        }
        [Test]
       public void Divide_ByZero_ThrowsException()
        {
           // var calc = new Calculators();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
        }




    }
}
