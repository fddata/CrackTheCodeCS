using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code.Chapter1;

namespace UnitTests
{
    [TestClass]
    public class C1Q1_Tests
    {
        //arrange
        private string _uniqueInput = "abcdefghijklmnopqrstuvwxyz";
        private string _duplicateInput = "aabcdefghijklmnopqrstuvwxyz";

        [TestMethod]
        public void ReturnsTrueIfUnique()
        {
            //act
            bool result = Q1_1.areAllCharsUnique(_uniqueInput);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void  ReturnsFalseIfNotUnique()
        {            
            //act
            bool result = Q1_1.areAllCharsUnique(_duplicateInput);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnTrueIfNull()
        {
            //act
            bool result = Q1_1.areAllCharsUnique("");

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnTrueIfUniqeNoAdditional()
        {
            //act
            bool result = Q1_1.areAllCharsUniqueNoAdditional(_uniqueInput);

            //assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void ReturnFalseIfNoUniqeNoAdditional()
        {
            //act
            bool result = Q1_1.areAllCharsUniqueNoAdditional(_duplicateInput);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnTrueIfNullNoAdditional()
        {
            //act
            bool result = Q1_1.areAllCharsUniqueNoAdditional("");

            //assert
            Assert.IsTrue(result);
        }

    }
}
