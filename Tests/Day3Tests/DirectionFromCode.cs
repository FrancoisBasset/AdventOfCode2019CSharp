using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2019CSharp.Day3;

namespace Tests.Day3Tests
{
    [TestClass]
    public class DirectionFromCode
    {
        [TestMethod]
        public void _1_should_return_Direction()
        {
            var direction = Movement.DirectionFromCode("U10");

            Assert.IsInstanceOfType(direction, typeof(Direction));
        }

        [TestMethod]
        public void _2_should_not_return_null()
        {
            var direction = Movement.DirectionFromCode("U10");

            Assert.IsNotNull(direction);
        }

        [DataTestMethod]
        [DataRow("U10")]
        [DataRow("U100")]
        [DataRow("U1000")]
        public void _3_should_be_up(string code)
        {
            Direction direction = Movement.DirectionFromCode(code);

            Assert.AreEqual(Direction.Up, direction);
        }

        [DataTestMethod]
        [DataRow("D10")]
        [DataRow("D100")]
        [DataRow("D1000")]
        public void _4_should_be_down(string code)
        {
            Direction direction = Movement.DirectionFromCode(code);

            Assert.AreEqual(Direction.Down, direction);
        }

        [DataTestMethod]
        [DataRow("L10")]
        [DataRow("L100")]
        [DataRow("L1000")]
        public void _5_should_be_left(string code)
        {
            Direction direction = Movement.DirectionFromCode(code);

            Assert.AreEqual(Direction.Left, direction);
        }

        [DataTestMethod]
        [DataRow("R10")]
        [DataRow("R100")]
        [DataRow("R1000")]
        public void _6_should_be_right(string code)
        {
            Direction direction = Movement.DirectionFromCode(code);

            Assert.AreEqual(direction, Direction.Right);
        }
    }
}