using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2019CSharp;

namespace Tests.Day1Tests
{
    [TestClass]
    public class GetNeededFuel
    {
        public static object[] DataRows {
            get
            {
                return new[] {
                    new object[] {12, 2},
                    new object[] {14, 2},
                    new object[] {1969, 966},
                    new object[] {100756, 50346},

                    new object[] {1827, 894},
                    new object[] {2020, 989},
                    new object[] {7875, 3913}
                };
            }
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _1_should_return_int(int mass, int expected)
        {
            int fuel = Day1.GetNeededFuel(mass);

            Assert.IsInstanceOfType(fuel, typeof(int));
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _2_should_be_positive(int mass, int expected)
        {
            int fuel = Day1.GetNeededFuel(mass);

            Assert.IsTrue(fuel > 0);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _3_should_be_less_than_mass(int mass, int expected)
        {
            int fuel = Day1.GetNeededFuel(mass);

            Assert.IsTrue(mass > fuel);
        }

        [DataTestMethod]
        [DynamicData("DataRows")]
        public void _4_fuel_should_be_equals_to_expected(int mass, int expected)
        {
            int fuel = Day1.GetNeededFuel(mass);

            Assert.AreEqual(expected, fuel);
        }
    }
}
