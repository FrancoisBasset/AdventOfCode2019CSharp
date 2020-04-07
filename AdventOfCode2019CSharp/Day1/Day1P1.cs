using System.Collections.Generic;

namespace AdventOfCode2019CSharp.Day1
{
    public class Day1P1 : Day1
    {
        public sealed override int GetNeededFuel(int mass)
        {
            return (mass / 3) - 2;
        }

        public sealed override int GetAllFuel(List<int> masses)
        {
            int fuel = 0;

            foreach (int mass in masses)
            {
                fuel += GetNeededFuel(mass);
            }

            return fuel;
        }
    }
}