using AdventOfCode2019CSharp.Day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Day2Tests
{
    [TestClass]
    public class GetNounAndVerbForIntCode
    {
        public static object[][] DataRows
        {
            get
            {
                return new object[][]
                {
                    new object[]
                    {
                        new int[] { 1, 0, 0, 0, 99 }, 198, 4, 4
                    },
                    new object[]
                    {
                        new int[] { 2, 0, 0, 0, 99, 2, 4, 6, 8 }, 8, 0, 6
                    },
                    new object[]
                    {
                        new int[] { 2, 0, 0, 0, 99, 2, 4, 6, 8 }, 48, 7, 8
                    }
                };
            }
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _1_should_return_tuple(int[] intCode, int value, int noun, int verb)
        {
            Tuple<int, int> result = Day2.GetNounAndVerbForIntCode(intCode, value);

            Assert.IsInstanceOfType(result, typeof(Tuple<int, int>));
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _2_should_not_be_null(int[] intCode, int value, int noun, int verb)
        {
            Tuple<int, int> result = Day2.GetNounAndVerbForIntCode(intCode, value);

            Assert.IsNotNull(result);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _3_noun_should_not_be_null(int[] intCode, int value, int noun, int verb)
        {
            Tuple<int, int> result = Day2.GetNounAndVerbForIntCode(intCode, value);

            Assert.IsNotNull(result.Item1);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _4_verb_should_not_be_null(int[] intCode, int value, int noun, int verb)
        {
            Tuple<int, int> result = Day2.GetNounAndVerbForIntCode(intCode, value);

            Assert.IsNotNull(result.Item2);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _5_noun_should_be_positive(int[] intCode, int value, int noun, int verb)
        {
            Tuple<int, int> result = Day2.GetNounAndVerbForIntCode(intCode, value);

            Assert.IsTrue(result.Item1 >= 0);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _6_verb_should_be_positive(int[] intCode, int value, int noun, int verb)
        {
            Tuple<int, int> result = Day2.GetNounAndVerbForIntCode(intCode, value);

            Assert.IsTrue(result.Item2 >= 0);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _7_should_return_correct_result(int[] intCode, int value, int noun, int verb)
        {
            Tuple<int, int> result = Day2.GetNounAndVerbForIntCode(intCode, value);

            Assert.AreEqual(noun, result.Item1);
            Assert.AreEqual(verb, result.Item2);
        }
    }
}