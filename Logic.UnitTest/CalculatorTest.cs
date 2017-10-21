using NUnit.Framework;
using System;

namespace Logic.UnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        #region Add
        [Test]
        public void Add_PositiveInputValues_PositiveTest()
        {
            double actual = Calculator.Add(3, 4);
            double expected = 7;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Add_PositiveAndNegativeInputValues_PositiveTest()
        {
            double actual = Calculator.Add(-3, 4);
            double expected = 1;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Add_NegativeAndPositiveInputValues_PositiveTest()
        {
            double actual = Calculator.Add(3, -4);
            double expected = -1;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Add_NegativeInputValues_PositiveTest()
        {
            double actual = Calculator.Add(-3, -4);
            double expected = -7;
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Substract
        [Test]
        public void Substract_PositiveInputValues_PositiveTest()
        {
            double actual = Calculator.Substract(10, 6);
            double expected = 4;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Substract_PositiveAndNegativeInputValues_PositiveTest()
        {
            double actual = Calculator.Substract(-10, 6);
            double expected = -16;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Substract_NegativeAndPositiveInputValues_PositiveTest()
        {
            double actual = Calculator.Substract(10, -6);
            double expected = 16;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Substract_NegativeInputValues_PositiveTest()
        {
            double actual = Calculator.Substract(-10, -6);
            double expected = -4;
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Multiply
        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(8, 10, ExpectedResult = 80)]
        [TestCase(3, 15, ExpectedResult = 45)]
        public double Multiply_PositiveInputValues_PositiveTest(double lhs, double rhs)
        {
            return Calculator.Multiply(lhs, rhs);
        }

        [TestCase(-2, 2, ExpectedResult = -4)]
        [TestCase(8, -10, ExpectedResult = -80)]
        [TestCase(-3, -15, ExpectedResult = 45)]
        public double Multiply_DifferentInputValues_PositiveTest(double lhs, double rhs)
        {
            return Calculator.Multiply(lhs, rhs);
        }

        [TestCase(1, 2, ExpectedResult = 2)]
        [TestCase(8, 1, ExpectedResult = 8)]
        [TestCase(1, 1, ExpectedResult = 1)]
        public double Multiply_OneNumberIsOne_SameNumberResult(double lhs, double rhs)
        {
            return Calculator.Multiply(lhs, rhs);
        }

        [TestCase(0, 2, ExpectedResult = 0)]
        [TestCase(8, 0, ExpectedResult = 0)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public double Multiply_OneNumberIsZero_ZeroResult(double lhs, double rhs)
        {
            return Calculator.Multiply(lhs, rhs);
        }
        #endregion

        #region Divide
        [TestCase(2, 2, ExpectedResult = 1)]
        [TestCase(80, 8, ExpectedResult = 10)]
        [TestCase(45, 3, ExpectedResult = 15)]
        public double Divide_PositiveInputValues_PositiveTest(double lhs, double rhs)
        {
            return Calculator.Divide(lhs, rhs);
        }

        [TestCase(-24, 6, ExpectedResult = -4)]
        [TestCase(310, -10, ExpectedResult = -31)]
        [TestCase(-15, -3, ExpectedResult = 5)]
        public double Divide_DifferentInputValues_PositiveTest(double lhs, double rhs)
        {
            return Calculator.Divide(lhs, rhs);
        }

        [TestCase(1, 2, ExpectedResult = 0.5)]
        [TestCase(8, 1, ExpectedResult = 8)]
        [TestCase(1, 1, ExpectedResult = 1)]
        public double Divide_OneNumberIsOne_PositiveTest(double lhs, double rhs)
        {
            return Calculator.Divide(lhs, rhs);
        }

        [Test]
        public void Divide_FirstNumberIsZero_ZeroResult()
        {
            double actual = Calculator.Divide(0, 13);
            double expected = 0;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Divide_SecondNumberIsZero_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => Calculator.Divide(13, 0));
        }

        [Test]
        public void Divide_FirstAndSecondNumberAreZero_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => Calculator.Divide(0, 0));
        }
        #endregion

    }
}
