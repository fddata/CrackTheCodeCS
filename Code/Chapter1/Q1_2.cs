using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Chapter1
{
    public static class Q1_2
    {
        //1.2 Check Permutation: Given two strings, write a method to decide if one is a permutation of the
        //other.
        //Hints: #7, #84, #722, #737 

        //There is one solution that is 0 (N log N) time. Another solution uses some space, but isO(N) time.
        //(Assume comparison is case-sensitive, space-significant, ASCII-based.)

        public static bool isPermutation(string str1, string str2)
        {
            
            if ((str1 == null ) || (str2 == null ))
            {
                throw new ArgumentNullException("argument(s) cannot be null");
            }
                
            
            if ((str1 == String.Empty) && (str2 == String.Empty)) //i.e. "" 
            {
                return true;
            }


            if(str1.Length != str2.Length)
            {
                return false;
            }

            var charArray1 = str1.ToCharArray();
            var charArray2 = str2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            for (int i = 0; i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    return false;
                }
            }
            
            return true;
        }


        public static bool isPermutationASCII(string str1, string str2)
        {
            //only works for ascii strings (256 char)

            if ((str1 == null) || (str2 == null))
            {
                throw new ArgumentNullException("argument(s) cannot be null");
            }


            if ((str1 == String.Empty) && (str2 == String.Empty)) //i.e. "" 
            {
                return true;
            }


            if (str1.Length != str2.Length)
            {
                return false;
            }


            var array1 =  new int[256];

            foreach (char c in str1)
            {
                array1[(int)c]++;
            }

            foreach(char c in str2)
            {
                if(array1[(int)c]  == 0)
                {
                    return false;
                }
                else
                {
                    array1[(int)c]--;
                }
            }
            return true;
        }





        public static bool isPermutationDict(string str1, string str2)
        {

            if ((str1 == null) || (str2 == null))
            {
                throw new ArgumentNullException("argument(s) cannot be null");
            }


            if ((str1 == String.Empty) && (str2 == String.Empty)) //i.e. "" 
            {
                return true;
            }


            if (str1.Length != str2.Length)
            {
                return false;
            }


            var dictionary1 = GetCharCountDictFromString(str1);
            var dictionary2 = GetCharCountDictFromString(str2);

            return (dictionary2)
                .OrderBy(kvp => kvp.Key)
                .SequenceEqual((dictionary1)
                                   .OrderBy(kvp => kvp.Key));


        }

        private static Dictionary<char, int> GetCharCountDictFromString(string inputString)
        {
            try
            {
                var dict = new Dictionary<char, int>();

                foreach (char character in inputString)
                {
                    if (dict.ContainsKey(character))
                    {
                        dict[character]++;
                    }
                    else
                    {
                        dict.Add(character, 1);
                    }
                }
                    return dict;
            }
            catch (Exception e)
            {
                Console.WriteLine($"GetCharCountDictFromString failed with message {e.Message}");
                return new Dictionary<char, int>();
            }
        }
    }
}
