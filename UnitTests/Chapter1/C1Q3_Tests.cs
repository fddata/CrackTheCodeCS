using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code.Chapter1;
using System;

namespace UnitTests.Chapter1
{
    [TestClass]
    public class C1Q3_Tests
    {
        //arrange
        

        [TestMethod]
        public void ArrayWithNoSpacesIsUnchanged()
        {
            //arrange
            var noSpaces = "noSpaces".ToCharArray();

            //act
            char[] result = Q1_3.GetHTMLSpaceStringFromCharArray(noSpaces, 8);

            //assert
            Assert.AreEqual(noSpaces, result);
        }


        [TestMethod]
        public void CanConvertOneSpace()
        {
            //arrange
            var oneSpaceBefore = "one space        ".ToCharArray();
            var oneSpaceAfter = "one%20space".ToCharArray();

            //act
            char[] result = Q1_3.GetHTMLSpaceStringFromCharArray(oneSpaceBefore, 9);

            //assert
            CompareCharArrays(result, oneSpaceAfter );
        }

        [TestMethod]
        public void CanConvertMultipleSpaces()
        {
            //arrange 
            var multipleSpacesBefore = "My Name is John Smith                ".ToCharArray();
            var multipleSpacesAfter = "My%20Name%20is%20John%20Smith".ToCharArray();

            //act
            char[] result = Q1_3.GetHTMLSpaceStringFromCharArray(multipleSpacesBefore, 21);
            
            //assert
            CompareCharArrays(result, multipleSpacesAfter);

        }


        
        /// <summary>
        /// Used to compare all the characters from an array to ensure conversion has occurred as expected
        /// </summary>
        private static void CompareCharArrays( char[] actualOutput, char[] expectedOutput)
        {
            for (int i = 0; i < expectedOutput.Length - 1; i++)
            {
                Assert.AreEqual(expectedOutput[i], actualOutput[i]);
            }

        }

        

    }
}
