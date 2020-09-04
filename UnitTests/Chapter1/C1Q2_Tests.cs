using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code.Chapter1;
using System;

namespace UnitTests.Chapter1
{
    [TestClass]
    public class C1Q2_Tests
    {
        //arrange
        private string _permutation1 = "abc def ghi";
        private string _permutation2 = "fed abc hig";
        private string _notpermuation = "not a permutation";


        [TestMethod]
        public void ReturnsTrueIfPermutation()
        {
            //act
            bool result = Q1_2.isPermutation(_permutation1, _permutation2);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnsFalseIfNotPermutation()
        {
            //act
            bool result = Q1_2.isPermutation(_permutation1, _notpermuation);

            //assert
            Assert.IsFalse(result);        
        }

        [TestMethod]
        public void RaisesExceptionIfNullPassed()
        {
            //arrange
            bool result;

            //act
            Action action = () => result = Q1_2.isPermutation(_permutation1, null);

            //assert
            Assert.ThrowsException<ArgumentNullException>( action );   
        }


    }
}
