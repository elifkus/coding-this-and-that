using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class ArraysAndStringsTest
    {
        [TestMethod]
        public void TestBasicallyCompress()
        {
            string str1 = "aabcccccaaa";
            string expected1 = "a2b1c5a3";

            string actual = ArraysAndStrings.BasicallyCompress(str1);
            Assert.AreEqual(expected1, actual);

            str1 = "abcdefg";
            actual = ArraysAndStrings.BasicallyCompress(str1);
            Assert.AreEqual(str1, actual);
        }
    }
}
