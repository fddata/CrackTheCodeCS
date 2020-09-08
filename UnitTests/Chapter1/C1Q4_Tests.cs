using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code.Chapter1;

namespace UnitTests.Chapter1
{
    [TestClass]
    public class C1Q4_Tests
    {
        private string _permutation = "akiviksaippiaspuaup"; //Pemutation of 'saippuakivikauppias' - the Finnish word for 'soapstone vendor' and supposedly the longest palindrome in everyday use:
        private string _notPermutation = "not a permutation";

        [TestMethod]
        public void PermutationReturnsTrue()
        {

            //act
            bool result = Q1_4.IsStringAPalindromePermutation(_permutation);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NonPermutationReturnsFalse()
        {
            //arrange
            

            //act
            bool result = Q1_4.IsStringAPalindromePermutation(_notPermutation);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PermutationReturnsTrueV2()
        {
            //arrange
            

            //act
            bool result = Q1_4.IsStringAPalindromePermutationV2(_permutation);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NonPermutationReturnsFalseV2()
        {
            //act
            bool result = Q1_4.IsStringAPalindromePermutationV2(_notPermutation);

            //assert
            Assert.IsFalse(result);
        }

    }
}
