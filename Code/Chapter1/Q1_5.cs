using System;

namespace Code.Chapter1
{
    public static class Q1_5
    {
        //One Away: There are three types of edits that can be performed on strings: insert a character,
        //remove a character, or replace a character.Given two strings, write a function to check if they are
        //one edit (or zero edits) away.
        //EXAMPLE
        //pale, pIe -> true
        //pales,pale -> true
        //pale,bale -> true
        //pale,bake -> false
        //Hints: #23, #97, #130 

        public static bool AreStringsAreOneEditAway(string string1, string string2)
        {

            if (Math.Abs(string1.Length - string2.Length) >= 2)
            {
                return false;
            }

            if (string1.Equals(string2) ||
                IsOneCharacterReplacement(string1, string2) || 
                IsOneCharacterInsertion(string1, string2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsOneCharacterInsertion(string string1, string string2)
        {
            string longString;
            string shortString;

            if (string1.Length > string2.Length)
            {
                longString = string1;
                shortString = string2;
            }
            else
            {
                longString = string2;
                shortString = string1;
            };

            bool foundReplaced = false;
            int shortIndex = 0;
            int longIndex = 0;

            while (shortIndex < shortString.Length - 1)
            {

                if (shortString[shortIndex] != longString[longIndex])
                {
                    if (foundReplaced)
                    {
                        return false;
                    }
                    else
                    {
                        foundReplaced = true;
                        longIndex++;
                    }
                }
                else
                {
                    shortIndex++;
                    longIndex++;
                }
            }
            return true;
        }

        private static bool IsOneCharacterReplacement(string string1, string string2)
        {
            int changeCounter = 0;

            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] != string2[i])
                {
                    changeCounter++;
                    if (changeCounter >= 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }



    }





}
