using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2019CSharp.Day1
{
    public abstract class Day1
    {
        public abstract int GetNeededFuel(int mass);
        public abstract int GetAllFuel(List<int> masses);

        public List<int> GetAllMasses()
        {
            StreamReader reader = new StreamReader("D:/Dev/AdventOfCode2019CSharp/AdventOfCode2019CSharp/Day1/masses.txt");

            List<int> masses = new List<int>();

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                masses.Add(Int32.Parse(line));
            }
            
            reader.Close();

            return masses;
        }
    }
}