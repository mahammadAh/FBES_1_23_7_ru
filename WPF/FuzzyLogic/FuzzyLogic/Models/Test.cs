using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Models
{
    internal class Test
    {
        public string Answer { get; set; }

        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }

        private int correctAnswer;

        public int CorrectAnswer
        {
            get { return correctAnswer; }
            set 
            { 
              if(correctAnswer > 4 || correctAnswer < 1)
                {
                    correctAnswer = 1;
                }
            }
        }

    }
}
