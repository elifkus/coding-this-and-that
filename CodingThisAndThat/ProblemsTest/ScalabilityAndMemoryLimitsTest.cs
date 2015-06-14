using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsTest
{
    [TestClass]
    public class ScalabilityAndMemoryLimitsTest
    {
        [TestMethod]
        public void TestFindDuplicates()
        {
            int[] numbers = new int[500];
            Random random = new Random();

            for (int k = 0; k < 500; k++)
            {
                numbers[k] = random.Next(32001);
            }

            numbers[0] = numbers[100];

            ScalabilityAndMemoryLimits.FindDuplicates(numbers);
        }
    }
}
