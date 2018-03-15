using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logic.Tests
{
    public class FilterTests
    {
        [TestClass]
        public class MathTests
        {
            [TestMethod]
            public void FilterDigit_NormalFilter_ReturnArray()
            {
                int[] expected = {27, 17, 78};
                int[] result = Filter.FilterDigit(7, 11, 12, 53, 8, 27, 14, 17, 78);
                for (int i = 0; i < expected.Length; i++)
                {
                    Assert.AreEqual(expected[i], result[i]);
                }
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void FilterDigit_ThrowArgumentException_NumberIsNotDigit()
            {
                var result = Filter.FilterDigit(72, 11, 12, 53, 8, 27, 14, 17, 78);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void FilterDigit_ThrowArgumentException_ArrayIsEmpty()
            {
                var result = Filter.FilterDigit(7);
            }
        }
    }
}