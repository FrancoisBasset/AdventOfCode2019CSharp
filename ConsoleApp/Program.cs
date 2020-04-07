using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2019CSharp;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ResultDay1();

            Console.ReadLine();
        }

        static void ResultDay1()
        {
            Console.WriteLine("Day1:");

            List<int> masses = Day1.GetAllMasses();

            int fuel = Day1.GetAllFuel_part1(masses);
            Console.WriteLine("\tPart 1 : Il faut {0} fuel", fuel);

            fuel = Day1.GetAllFuel(masses);
            Console.WriteLine("\tPart 2 : Il faut {0} fuel", fuel);
        }
    }
}
