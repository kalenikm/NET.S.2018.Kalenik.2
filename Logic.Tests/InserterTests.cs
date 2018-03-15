using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Logic.Tests
{
    [TestClass]
    public class InserterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumber_ThrowException_WrongInterval()
        {
            Inserter.InsertNumber(7, 12, 9, 6);
        }

        [TestMethod]
        public void InsertNumber_NormalInsert_ReturnResult1()
        {
            int expected = 19;
            int result = Inserter.InsertNumber(7, 12, 2, 4);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InsertNumber_NormalInsert_ReturnResult2()
        {
            int expected = 120;
            int result = Inserter.InsertNumber(8, 15, 3, 8);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InsertNumber_NormalInsert_ReturnResult3()
        {
            int expected = 15;
            int result = Inserter.InsertNumber(15, 15, 0, 0);
            Assert.AreEqual(expected, result);
        }

        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 2, 2, 3, ExpectedResult = 8)]
        [TestCase(3, 15, 4, 5, ExpectedResult = 51)]
        [TestCase(8, 7, 1, 1, ExpectedResult = 10)]
        [TestCase(8, 10, 1, 2, ExpectedResult = 12)]
        public int InsertTest(int a, int b, int i, int j)
        {
            return Inserter.InsertNumber(a, b, i, j);
        }
    }
}
