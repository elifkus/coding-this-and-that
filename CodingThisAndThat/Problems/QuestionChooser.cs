using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class QuestionChooser
    {
        Random random;
        int[] numberOfQuestions;

        public QuestionChooser()
        {
            this.random = new Random();
            numberOfQuestions = new int[]{8, 7, 7, 9, 8, 6, 7, 10, 11, 7, 8, 6, 10, 6, 7, 6, 14, 13};
        }

        public string GiveMeAQuestion() {
            int firstPart = random.Next(numberOfQuestions.Length);

            int secondPart = random.Next(1, numberOfQuestions[firstPart]+1);
            firstPart += 1;
                
            return firstPart.ToString() + "-" + secondPart.ToString();
        }
    }
}
