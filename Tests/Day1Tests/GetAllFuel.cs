using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2019CSharp.Day1;
using System.Collections.Generic;

namespace Tests.Day1Tests
{
    [TestClass]
    public class GetAllFuel
    {
        private readonly Day1 _day1;
        public static object[][] DataRows
        {
            get
            {
                return new[]
                {
                    new object[] {
                        new [] {50, 100, 200},
                        142
                    },
                    new object[] {
                        new [] {1492, 1789, 2020},
                        2593
                    }
                };
            }
        }

        public GetAllFuel()
        {
            _day1 = new Day1P2();
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _1_should_be_not_null(int[] masses, int expected)
        {
            int fuel = _day1.GetAllFuel(new List<int>());

            Assert.IsNotNull(fuel);
        }

        [TestMethod]
        [DynamicData("DataRows")]
        public void _2_should_return_an_int(int[] masses, int expected)
        {
            int fuel = _day1.GetAllFuel(new List<int>());

            Assert.IsInstanceOfType(fuel, typeof(int));
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _3_should_return_correct_result(int[] masses, int expected)
        {
            int fuel = _day1.GetAllFuel(new List<int>(masses));

            Assert.AreEqual(expected, fuel);
        }
    }
}
