using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2019CSharp;
using System.Collections.Generic;

namespace Tests.Day1Tests
{
    [TestClass]
    public class GetAllMasses
    {
        [TestMethod]
        public void _1_should_return_int_list()
        {
            List<int> masses = Day1.GetAllMasses();

            Assert.IsInstanceOfType(masses, typeof(List<int>));
        }

        [TestMethod]
        public void _2_should_not_be_null()
        {
            List<int> masses = Day1.GetAllMasses();

            Assert.IsNotNull(masses);
        }

        [TestMethod]
        public void _3_should_not_be_empty()
        {
            List<int> masses = Day1.GetAllMasses();

            Assert.IsTrue(masses.Count > 0);
        }

        [TestMethod]
        public void _4_should_length_100()
        {            
            List<int> masses = Day1.GetAllMasses();

            Assert.AreEqual(100, masses.Count);
        }
    }
}
