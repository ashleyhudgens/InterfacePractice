using TestingInterfaces;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            //arrange
            var result = new Arithmetic();
            //act
            result.typeOfArithmetic = "add";
            result.firstOperand = 1;
            result.secondOperand = 2;
            result.getDisplayTotal();
            //assert
            Assert.AreEqual(result.total, 3);
        }

        [TestMethod]
        public void TestMethodSubtract()
        {
            //arrange
            var result = new Arithmetic();
            //act
            result.typeOfArithmetic = "subtract";
            result.firstOperand = 10;
            result.secondOperand = 2;
            result.getDisplayTotal();
            //assert
            Assert.AreEqual(result.total, 8);
        }

        [TestMethod]
        public void TestMethodMultiply()
        {
            //arrange
            var result = new Arithmetic();
            //act
            result.typeOfArithmetic = "multiply";
            result.firstOperand = 6;
            result.secondOperand = 6;
            result.getDisplayTotal();
            //assert
            Assert.AreEqual(result.total, 36);
        }

        [TestMethod]
        public void TestMethodDivide()
        {
            //arrange
            var result = new Arithmetic();
            //act
            result.typeOfArithmetic = "divide";
            result.firstOperand = 50;
            result.secondOperand = 5;
            result.getDisplayTotal();
            //assert
            Assert.AreEqual(result.total, 10);
        }
    }
}
