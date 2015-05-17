using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
using System.Diagnostics;

namespace ProblemsTest
{
    [TestClass]
    public class QuestionChooserTest
    {
        private QuestionChooser questionChooser;

        [TestInitialize]
        public void Setup()
        {
            questionChooser = new QuestionChooser();
        }

        [TestMethod]
        public void TestGiveMeAQuestion()
        {
           string actual = questionChooser.GiveMeAQuestion();
           Assert.IsNotNull(actual);
           Assert.IsTrue(actual.Length > 0);
           Assert.IsTrue(actual.Contains("-"));

           Trace.WriteLine("Output: " + actual);
        }
    }
}
