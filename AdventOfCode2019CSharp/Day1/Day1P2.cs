using System.Collections.Generic;

namespace AdventOfCode2019CSharp
{
    public class Day1P2 : Day1
    {
        public sealed override int GetNeededFuel(int mass)
        {
            int fuel = 0;

            while (mass > 0)
            {
                mass = (mass / 3) - 2;

                if (mass > 0)
                {
                    fuel += mass;
                }
                else
                {
                    break;
                }
            }

            return fuel;
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