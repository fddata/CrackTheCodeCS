using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code.Chapter1;

namespace UnitTests.Chapter1
{
    [TestClass]
    public class C1Q5_Tests
    {
        [TestMethod]
        public void ReturnTrueIfStringsAreTheSame()
        {
            //arrange
            var string1 = "ABC";
            var string2 = "ABC";

            //act
            bool result = Q1_5.AreStringsAreOneEditAway(string1, string2);

            //assert
            Assert.IsTrue(result);
        }



        [TestMethod]
        public void ReturnsFalseIfStringsLengthDeltaIsGreaterThanTwo()
        {
            //arrange
            var string1 = "ABC";
            var string2 = "ABCDE";

            //act
            bool result = Q1_5.AreStringsAreOneEditAway(string1, string2);

            //assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void TwoChangesReturnsFalse()
        {
            //arrange
            var string1 = "pale";
            var string2 = "bake";

            //act
            bool result = Q1_5.AreStringsAreOneEditAway(string1, string2);

            //assert
            Assert.IsFalse(result);
        }



    }
}
