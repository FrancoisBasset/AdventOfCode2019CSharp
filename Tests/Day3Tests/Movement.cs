using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2019CSharp.Day3;

namespace Tests.Day3Tests
{
    [TestClass]
    public class MovementConstructor
    {
        [TestMethod]
        public void _1_movement_should_not_be_null()
        {
            Movement movement = new Movement("U10");

            Assert.IsNotNull(movement);
        }

        [TestMethod]
        public void _2_direction_should_not_be_null()
        {
            Movement movement = new Movement("U10");

            Assert.IsNotNull(movement.Direction);
        }
    }
}