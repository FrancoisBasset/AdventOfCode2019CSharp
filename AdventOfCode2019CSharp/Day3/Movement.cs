using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019CSharp.Day3
{
    public struct Movement
    {
        public Direction Direction { get; }
        public int Distance { get; }

        public Movement(string code)
        {
            Direction = DirectionFromCode(code);
            Distance = DistanceFromCode(code);
        }

        public static Direction DirectionFromCode(string code)
        {
            return (Direction) code[0];
        }

        public static int DistanceFromCode(string code)
        {
            return Int32.Parse(code.Substring(1));
        }
    }
}