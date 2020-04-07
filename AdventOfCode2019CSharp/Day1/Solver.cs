using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2019CSharp
{
    public static class Day1
    {
        public static int GetNeededFuel_part1(int mass)
        {
            return (mass / 3) - 2;
        }

        public static int GetAllFuel_part1(List<int> masses)
        {
            int fuel = 0;

            foreach (int mass in masses)
            {
                fuel += GetNeededFuel_part1(mass);
            }

            return fuel;
        }

        public static int GetNeededFuel(int mass)
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

        public static List<int> GetAllMasses()
        {
            FileStream fs = new FileStream("D:/Dev/AdventOfCode2019CSharp/AdventOfCode2019CSharp/Day1/masses.txt", FileMode.Open);
            StreamReader reader = new StreamReader(fs);

            List<int> masses = new List<int>();
                        
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                masses.Add(Int32.Parse(line));
            }

            fs.Close();

            return masses;
        }

        public static int GetAllFuel(List<int> masses)
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