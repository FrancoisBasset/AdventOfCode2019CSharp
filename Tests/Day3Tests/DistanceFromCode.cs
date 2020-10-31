using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2019CSharp.Day3;

namespace Tests.Day3Tests
{
    [TestClass]
    public class DistanceFromCode
    {
        public static object[][] DataRows
        {
            get
            {
                return new object[][]
                {
                    new object[] { "U100", 100 },
                    new object[] { "U1000", 1000 },
                    new object[] { "U10000", 10000 }
                };
            }
        }
        
        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _1_should_return_int(string code, int expected)
        {
            int distance = Movement.DistanceFromCode("U10");

            Assert.IsInstanceOfType(distance, typeof(int));
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _2_should_not_be_null(string code, int expected)
        {
            int distance = Movement.DistanceFromCode("U10");

            Assert.IsNotNull(distance);
        }

        [TestMethod]
        public void _3_should_return_10()
        {
            int distance = Movement.DistanceFromCode("U10");

            Assert.AreEqual(10, distance);
        }

        [TestMethod]
        public void _4_should_return_100()
        {
            int distance = Movement.DistanceFromCode("U100");

            Assert.AreEqual(100, distance);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _5_should_return_correct_distance(string code, int expected)
        {
            int distance = Movement.DistanceFromCode(code);

            Assert.AreEqual(expected, distance);
        }
    }
}