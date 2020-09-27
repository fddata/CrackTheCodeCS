using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code.Chapter1;

namespace UnitTests.Chapter1
{
    [TestClass]
    public class C1Q6_Tests
    { 

        [TestMethod]
        public void LongStringNoDuplicatesReturnsOriginal()
        {
            //ARRANGE
            string noDuplicates = "abcdefgh";

            //ACT
            var result = Q1_6.CompressString(noDuplicates);

            //ASSERT
            Assert.AreEqual("abcdefgh", result);
        }


        [TestMethod]
        public void StringWithDuplicatesCompressedOK()
        {
            //ARRANGE
            string duplicates = "aabcccccaaa";

            //ACT
            var result = Q1_6.CompressString(duplicates);

            //ASSERT
            Assert.AreEqual("a2b1c5a3",result);
        }

        [TestMethod]
        public void StringWithDuplicatesCompressedOKWithSinglesAtEnd()
        {
            //ARRANGE
            string duplicates2 = "aabcccccaaaddddddddddddddddddddddddefg";

            //ACT
            var result = Q1_6.CompressString(duplicates2);

            //ASSERT
            Assert.AreEqual("a2b1c5a3d24e1f1g1", result);
        }



    }
}
