using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAUnitTestExample;

namespace DSAUnitTestExample.Tests
{
    [TestClass]
    public class ArrayUtilsTests
    {
        [TestMethod]
        public void ArraySum_NormalInput_ReturnsSum()
        {
           
            int[] input = { 1, 2, 3 };

            
            int result = ArrayUtils.ArraySum(input);

           
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ArraySum_EmptyArray_ReturnsZero()
        {
            
            int[] input = { };

            
            int result = ArrayUtils.ArraySum(input);

            
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ArraySum_SingleElement_ReturnsElement()
        {
            
            int[] input = { 5 };

           
            int result = ArrayUtils.ArraySum(input);

            
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ArraySum_NegativeNumbers_ReturnsCorrectSum()
        {
            
            int[] input = { -1, -2, -3 };

           
            int result = ArrayUtils.ArraySum(input);

            
            Assert.AreEqual(-6, result);
        }
    }
}