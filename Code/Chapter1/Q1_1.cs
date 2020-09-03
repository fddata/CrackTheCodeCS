using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Chapter1
{
    public static class Q1_1
    {
        // 1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters.What if you
        //cannot use additional data structures?
        //Hints: #44, # 777, # 7 32 
        
        public static bool areAllCharsUnique(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                return true;
            }

            HashSet<char> characterHash = new HashSet<char>();

            foreach (char character in inputString)
            {
                if (!characterHash.Add(character))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool areAllCharsUniqueNoAdditional(string inputString)
        {
            //cannot use additional data structures so loop through
            //each letter and compare it with the remaining letters


            if (String.IsNullOrEmpty(inputString))
            {
                return true;
            }


            for (int i = 0; i < inputString.Length; i++)
            {
                for (int j = i + 1; j < inputString.Length; j++)
                {
                    if (inputString[i] == inputString[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }



    }
}
