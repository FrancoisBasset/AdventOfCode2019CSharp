using AdventOfCode2019CSharp.Day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Day2Tests
{
    [TestClass]
    public class ExecuteIntcode
    {
        public static object[][] DataRows
        {
            get
            {
                return new object[][]
                {
                    new object[]
                    {
                        new int[] {1, 5, 6, 7, 99, 6, 8, 0},
                        new int[] {1, 5, 6, 7, 99, 6, 8, 14}
                    },
                    new object[]
                    {
                        new int[] {1, 0, 0, 0, 99},
                        new int[] {2, 0, 0, 0, 99}
                    },
                    new object[]
                    {
                        new int[] {2, 3, 0, 3, 99},
                        new int[] {2, 3, 0, 6, 99}
                    },
                    new object[]
                    {
                        new int[] {2, 4, 4, 5, 99, 0},
                        new int[] {2, 4, 4, 5, 99, 9801}
                    }
                };
            }
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _1_should_return_int_array(int[] intCode, int[] expected)
        {
            int[] result = Day2.ExecuteIntCode(intCode);

            Assert.IsInstanceOfType(result, typeof(int[]));
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _2_should_not_be_null(int[] intCode, int[] expected)
        {
            int[] result = Day2.ExecuteIntCode(intCode);

            Assert.IsNotNull(result);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _3_should_have_same_length(int[] intCode, int[] expected)
        {
            int[] result = Day2.ExecuteIntCode(intCode);

            Assert.AreEqual(intCode.Length, result.Length);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _4_should_not_return_same_reference(int[] intCode, int[] expected)
        {
            int[] result = Day2.ExecuteIntCode(intCode);

            Assert.IsTrue(result != intCode);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _5_should_return_correct_result(int[] intCode, int[] expected)
        {
            int[] result = Day2.ExecuteIntCode(intCode);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}