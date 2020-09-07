using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Chapter1
{
    public static class Q1_3
    {
        //URLify: Write a method to replace all spaces in a string with '%20: You may assume that the string
        //has sufficient space at the end to hold the additional characters, and that you are given the "true"
        //length of the string. (Note: If implementing in Java, please use a character array so that you can
        //perform this operation in place.)
        //Hints: #53, #118

        public static char[] GetHTMLSpaceStringFromCharArray(char[] chars, int length)
        {
            if(chars == null)
            {
                throw new ArgumentNullException(" argument cannot be null ");
            }

            if (length == 0)
            {
                return chars;  //received an empty array, so just return it 
            }

            int numSpaces = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                if (chars[i] == ' ')
                {
                    numSpaces++;
                }
            }

            if (numSpaces == 0)
            {
                return chars;  //no spaces, so just return it 
            }

            var offset = numSpaces * 2;
            
            Console.WriteLine($"numSpaces is {numSpaces}");
            for(int i = length - 1; i >= 0; i--)
            {
                if(chars[i] == ' ')
                {
                    chars[i + offset - 2] = '%';
                    chars[i + offset - 1] = '2';
                    chars[i + offset ] = '0';

                    offset -= 2;
                }
                else
                {
                    chars[i + offset] = chars[i];
                }

                Console.WriteLine($"chars is now: { new string(chars)}");
                Console.WriteLine($"offset is now: {offset}");
            }            

            return chars;
            
        }


    }
}
