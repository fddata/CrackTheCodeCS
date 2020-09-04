using System;
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
    }
}
