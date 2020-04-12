using AdventOfCode2019CSharp.Day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Day2Tests
{
    [TestClass]
    public class GetIntCode
    {
        [TestMethod]
        public void _1_should_return_int_array()
        {
            int[] intCode = Day2.GetIntCode();

            Assert.IsInstanceOfType(intCode, typeof(int[]));
        }

        [TestMethod]
        public void _2_should_not_return_null()
        {
            int[] intCode = Day2.GetIntCode();

            Assert.IsNotNull(intCode);
        }

        [TestMethod]
        public void _3_should_not_be_empty()
        {
            int[] intCode = Day2.GetIntCode();

            Assert.IsTrue(intCode.Length > 0);
        }

        [TestMethod]
        public void _4_should_length_145()
        {
            int[] intCode = Day2.GetIntCode();

            Assert.AreEqual(145, intCode.Length);
        }

        [TestMethod]
        public void _5_position_1_should_be_12()
        {
            int[] intCode = Day2.GetIntCode();

            Assert.AreEqual(12, intCode[1]);
        }

        [TestMethod]
        public void _6_position_2_should_be_2()
        {
            int[] intCode = Day2.GetIntCode();

            Assert.AreEqual(2, intCode[2]);
        }
    }
}