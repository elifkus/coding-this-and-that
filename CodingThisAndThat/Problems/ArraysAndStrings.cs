using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class ArraysAndStrings
    {
        public static string BasicallyCompress(string str) 
        {
            StringBuilder builder = new StringBuilder();
            
            char[] letters = str.ToCharArray();

            int currenctCount = 0;
            char previous = char.MaxValue;

            for (int i = 0; i < letters.Length; i++)
            {
                if (i == 0) 
                {
                    previous = letters[i];
                    currenctCount += 1;
                    continue;
                }

                if (previous != letters[i])
                {
                    
                    builder.Append(previous);
                    builder.Append(currenctCount);

                    previous = letters[i];
                    currenctCount = 0;
                }

                currenctCount += 1;
    
            }

            builder.Append(previous);
            builder.Append(currenctCount);
                
            string compressedStr = builder.ToString();

            if (compressedStr.Length < str.Length)
            {
                return compressedStr;
            }
            else 
            {
                return str;
            }
        }
    }
}
