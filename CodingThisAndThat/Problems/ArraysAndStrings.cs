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
            string compressedStr = Compress(str);

            if (compressedStr.Length < str.Length)
            {
                return compressedStr;
            }
            else 
            {
                return str;
            }
        }

        public static string BasicallyCompressWithInitialCheck(string str)
        {
            bool compressionWorks = checkIfCompressionCanCompressToSmallerString(str);

            if (compressionWorks) { 
                return Compress(str);
            }
            else 
            {
                return str;
            }
        }

        private static string Compress(string str)
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
            return compressedStr;
        }

        private static bool checkIfCompressionCanCompressToSmallerString(String str)
        {
            char[] letters = str.ToCharArray();
            char previous = letters[0];
            int count = 0;
            int compressionCounter = 0;

            foreach (char letter in letters) 
            {
                if (count == 0)
                {
                    count += 1;
                    continue;
                }

                if (previous != letter)
                {
                    compressionCounter += count - 2;
                    count = 0;
                    previous = letter;
                }

                count += 1;

            }
            compressionCounter += count - 2;

            if (compressionCounter > 0)
            {

                return true;
            }

            return false;
        }
    }
}
