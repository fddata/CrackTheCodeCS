using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Chapter1
{
    public static class Q1_6
    {
        //String Compression: Implement a method to perform basic string compression using the counts
        //of repeated characters.For example, the string aabcccccaaa would become a2b1c5a3.If the
        //"compressed" string would not become smaller than the original string, your method should return
        //the original string. You can assume the string has only uppercase and lowercase letters (a - z). 

        public static string CompressString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("CompressString method found null or empty parameter:", nameof(input));
            }

            if (input.Length == 1)
            {
                return input;
            }

            int inputLength = input.Length;

            string result = string.Empty;  

            for (int i = 0; i < inputLength; i++)
            {
                int counter = 1;
                int j = 1;
                char currentChar = input[i];

                if((i > 0) && input[i-1] == currentChar) //is a duplicate and has been accounted for, skip this loop.
                {
                    continue;
                }

                if ((i == inputLength - 1) || (input[i+1] != currentChar)) //is a standalone character
                {
                    result += (currentChar + counter.ToString());
                }
                else //is the first in a series
                {
                    while (( (i + j) < inputLength) && (input[i + j] == currentChar))
                    {
                        counter++;
                        j++;
                    }
                    result += (currentChar + counter.ToString());
                }
            }

            if (inputLength <= result.Length)
            {
                return input;
            }
            else
            {
                return result;
            }
        }
        
        /// <summary>
        /// Different (and simpler than above) method utilising the StringBuilder class
        /// </summary>
        public static string CompressStringV2(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("CompressString method found null or empty parameter:", nameof(input));
            }

            if (input.Length == 1)
            {
                return input;
            }

            var result = new StringBuilder();

            char currentChar = input[0];
            int counter = 1;

            for(int i = 1; i < input.Length; i++)
            {
                if( input[i] == currentChar)
                {
                    counter++;
                }
                else
                {
                    result.Append(currentChar);
                    result.Append(counter);
                    counter = 1;
                    currentChar = input[i];
                }
            }

            result.Append(currentChar);
            result.Append(counter);

            if (input.Length <= result.Length)
            {
                return input;
            }
            else
            {
                return result.ToString();
            }
        }
    }
}

