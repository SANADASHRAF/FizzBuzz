using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Fizz_Buzz
    {
        public Result New_Fizz_Buzz_Result(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new Exception("you must enter valid string");
            

            string[] words = SplitWords(input);
            int TotalCounter= 0;
            StringBuilder outputStringBuilder = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (string.IsNullOrEmpty(word))
                {
                    continue;
                }

                if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
                {
                    outputStringBuilder.Append("FizzBuzz ");
                    TotalCounter++;
                }
                else if ((i + 1) % 3 == 0)
                {
                    outputStringBuilder.Append("Fizz ");
                    TotalCounter++;
                }
                else if ((i + 1) % 5 == 0)
                {
                    outputStringBuilder.Append("Buzz ");
                    TotalCounter++;
                }
                else
                {
                    outputStringBuilder.Append(word + " ");
                }
            }

            string outputString = outputStringBuilder.ToString().Trim();

            return new Result
            {
                Output = outputString,
                counter = TotalCounter
            };
        }

        public string[] SplitWords(string input)
        {
            
            StringBuilder NewString = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    NewString.Append(c);
                }
                else if (NewString.Length > 0 && NewString[NewString.Length - 1] != ' ')
                {
                    NewString.Append(' ');
                }
            }
            return NewString.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }



}


