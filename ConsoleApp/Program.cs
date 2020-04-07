using AdventOfCode2019CSharp.Day1;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ResultDay1();

            Console.ReadLine();
        }

        public static void ResultDay1()
        {
            Console.WriteLine("Day1:");

            Day1 p1 = new Day1P1();
            Day1 p2 = new Day1P2();

            List<int> masses = p1.GetAllMasses();

            int fuel = p1.GetAllFuel(masses);
            Console.WriteLine("\tPart 1 : Il faut {0} fuel", fuel);

            fuel = p2.GetAllFuel(masses);
            Console.WriteLine("\tPart 2 : Il faut {0} fuel", fuel);
        }
    }
}
