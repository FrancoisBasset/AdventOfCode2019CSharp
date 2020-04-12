using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2019CSharp.Day2;

namespace Tests.Day2Tests
{
    [TestClass]
    public class ExecuteIntCodeWithNounAndVerb
    {
        public static object[][] DataRows
        {
            get
            {
                return new object[][]
                {
                    new object[]
                    {
                        new int[] { 1, 0, 0, 0, 99 },
                        4,
                        4,
                        new int[] { 198, 4, 4, 0, 99 }
                    },
                    new object[]
                    {
                        new int[] { 2, 99, 99, 3, 99 },
                        0,
                        4,
                        new int[] { 2, 0, 4, 198, 99 }
                    }
                };
            }
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _1_should_return_int_array(int[] intCode, int noun, int verb, int[] expected)
        {
            int[] result = Day2.ExecuteIntCodeWithNounAndVerb(intCode, noun, verb);

            Assert.IsInstanceOfType(result, typeof(int[]));
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _2_should_not_be_null(int[] intCode, int noun, int verb, int[] expected)
        {
            int[] result = Day2.ExecuteIntCodeWithNounAndVerb(intCode, noun, verb);

            Assert.IsNotNull(result);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _3_should_not_be_empty(int[] intCode, int noun, int verb, int[] expected)
        {
            int[] result = Day2.ExecuteIntCodeWithNounAndVerb(intCode, noun, verb);

            Assert.IsTrue(result.Length > 0);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _4_should_have_same_length(int[] intCode, int noun, int verb, int[] expected)
        {
            int[] result = Day2.ExecuteIntCodeWithNounAndVerb(intCode, noun, verb);

            Assert.AreEqual(5, result.Length);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _5_should_return_correct_result(int[] intCode, int noun, int verb, int[] expected)
        {
            int[] result = Day2.ExecuteIntCodeWithNounAndVerb(intCode, noun, verb);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}