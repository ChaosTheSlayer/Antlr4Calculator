﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubberduck.Math;

namespace CalculatorTests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void OrderedOperation()
        {
            var expr = "1 + 6 - 2 * 3 / 2";
            // 2 * 3 = 6
            // 6 / 2 = 3
            // 1 + 6 = 7
            // 7 - 3 = 4
            Assert.AreEqual(4, Calculator.Evaluate(expr));
        }

        [TestMethod]
        public void SimpleExponentation()
        {
            var expr = "2 ^ 3";
            Assert.AreEqual(8, Calculator.Evaluate(expr));
        }

        [TestMethod]
        public void Exponentation_Before_Addition()
        {
            var expr = "2 ^ 3 + 2";
            Assert.AreEqual(10, Calculator.Evaluate(expr));
        }

        [TestMethod]
        public void Exponentation_Before_Multiplication()
        {
            var expr = "2 ^ 3 * 2";
            Assert.AreEqual(16, Calculator.Evaluate(expr));
        }

        [TestMethod]
        public void MultiplicationAndDivisionShouldHaveSamePrecedence()
        {
            var expr = "10 / 2 * 5";
            Assert.AreEqual(25, Calculator.Evaluate(expr));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcceptOnlyOneExpression()
        {
            var expr = "1+1 2-2 3*3";
            var answer = Calculator.Evaluate(expr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsArgExceptionForInvalidTokens()
        {
            var expr = "1 + 5 + 2(3)";
            int value = Calculator.Evaluate(expr);
        }

        [TestMethod]
        public void SimpleAddition()
        {
            Assert.AreEqual(2, Calculator.Evaluate("1 + 1"));
        }

        [TestMethod]
        public void RepeatedAddition()
        {
            Assert.AreEqual(10, Calculator.Evaluate("1 + 2 + 3 + 4"));
        }

        [TestMethod]
        public void SimpleSubtraction()
        {
            Assert.AreEqual(2, Calculator.Evaluate("4 - 2"));
        }

        [TestMethod]
        public void RepeatedSubtraction()
        {
            Assert.AreEqual(5, Calculator.Evaluate("10 - 3 - 2"));
        }

        [TestMethod]
        public void SimpleMultiplication()
        {
            Assert.AreEqual(4, Calculator.Evaluate("2 * 2"));
        }

        [TestMethod]
        public void RepeatedMultiplication()
        {
            Assert.AreEqual(8, Calculator.Evaluate("2 * 2 * 2"));
        }

        [TestMethod]
        public void SimpleDivision()
        {
            Assert.AreEqual(2, Calculator.Evaluate("4 / 2"));
        }

        [TestMethod]
        public void RepeatedDivision()
        {
            Assert.AreEqual(2, Calculator.Evaluate("8 / 2 / 2"));
        }
    }
}
