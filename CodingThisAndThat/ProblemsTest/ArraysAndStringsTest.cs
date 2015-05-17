using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
using System.Diagnostics;

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

         [TestMethod]
        public void TestBasicallyCompressWithInitialCheck()
        {
            string str1 = "aabcccccaaa";
            string expected1 = "a2b1c5a3";

            string actual = ArraysAndStrings.BasicallyCompressWithInitialCheck(str1);
            Assert.AreEqual(expected1, actual);

            str1 = "abcdefg";
            actual = ArraysAndStrings.BasicallyCompressWithInitialCheck(str1);
            Assert.AreEqual(str1, actual);
        }

        [TestMethod]
         public void TestWhichCompressionIsFaster()
         {
             Stopwatch stopWatch = new Stopwatch();
             
             string str1 = "aabcccccaaa";
             string str2 = "abcdefg";

             stopWatch.Start();
             for(int i=0; i<1000; i++)
             {
                 ArraysAndStrings.BasicallyCompress(str1);
                 ArraysAndStrings.BasicallyCompress(str2);
             }
             stopWatch.Stop();
             Trace.WriteLine(stopWatch.Elapsed.ToString());

             stopWatch.Reset();
             stopWatch.Start();
             for (int i = 0; i < 1000; i++)
             {
                 ArraysAndStrings.BasicallyCompressWithInitialCheck(str1);
                 ArraysAndStrings.BasicallyCompressWithInitialCheck(str2);
             }
             stopWatch.Stop();
             Trace.WriteLine(stopWatch.Elapsed.ToString());
         }
    }
}
