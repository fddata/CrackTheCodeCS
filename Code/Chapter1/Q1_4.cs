using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Chapter1
{
    public static class Q1_4
    {
        //Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome.
        //A palindrome is a word or phrase that is the same forwards and backwards.A permutation 
        //is a rearrangement of letters.The palindrome does not need to be limited to just dictionary words.
        //EXAMPLE
        //Input: Tact Coa
        //Output: True (permutations: "taco cat". "atco cta". etc.)
        //Hints: #106, #121, #134, #136 


        public static bool IsStringAPalindromePermutation(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException( nameof(input), "Argument cannot be null");
            }

            input = input.Replace(" ", String.Empty);
            

            var dict = new Dictionary<char, int>();

            foreach (char character in input)
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

            bool foundOdd = false;

            foreach (KeyValuePair<char, int> entry in dict)
            {
                if (entry.Value % 2 != 0)
                {
                    if (foundOdd)
                    {
                        return false;
                    }
                    else
                    {
                        foundOdd = true;
                    }
                }

            }

            return true;
        }

        /// <summary>
        /// Uses an alternating bool to record odd or even number of character occurrences (will be faster 
        /// than performing equals check on a (potentially) large integer as in example above
        /// </summary>
        public static bool IsStringAPalindromePermutationV2(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Argument cannot be null");
            }

            input = input.Replace(" ", String.Empty);

            var charOccurances = new Dictionary<char, bool>();

            foreach (char character in input)
            {
                bool value;

                charOccurances.TryGetValue(character, out value);

                charOccurances[character] = (!value);
            }

            bool foundOdd = false;

            foreach (KeyValuePair<char, bool> entry in charOccurances)
            {
                if (entry.Value) //if its been flagged as odd number of occurrences above
                {
                    if (foundOdd)
                    {
                        return false;
                    }
                    else
                    {
                        foundOdd = true;
                    }
                }

            }

            return true;
        }

    }

}
