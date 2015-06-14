using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class ScalabilityAndMemoryLimits
    {
        public static void FindDuplicates(int[] numbers)
        {
            UInt32[] exists = new UInt32[1024];
            int count = 0;
            foreach (int number in numbers)
            {
                int i = number / 32;
                int rem = ((int)number % 32);

                if ((exists[i] & 1U << rem) > 0)
                {
                    Trace.WriteLine("Duplicate at "+count+": "  + number);
                }
                else
                {
                    exists[i] = exists[i] | 1U << rem;
                }
                count++;
            }
        }

       

    }
}
