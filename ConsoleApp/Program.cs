using AdventOfCode2019CSharp.Day1;
using System;
using System.Collections.Generic;
using AdventOfCode2019CSharp.Day2;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ResultDay1();
            ResultDay2();

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

        public static void ResultDay2()
        {
            Console.WriteLine("Day2:");

            int[] intCode = Day2.GetIntCode();
            int[] result = Day2.ExecuteIntCode(intCode);

            Console.WriteLine("\tPart 1: Le premier nombre est {0}", result[0]);

            intCode = Day2.GetIntCode();
            Tuple<int, int> nounVerb = Day2.GetNounAndVerbForIntCode(intCode, 19690720);
            int noun = nounVerb.Item1;
            int verb = nounVerb.Item2;

            int answer = 100 * nounVerb.Item1 + nounVerb.Item2;

            Console.WriteLine("\tPart 2: Le nom est {0}, le verbe est {1}", noun, verb);
            Console.WriteLine("\tLa réponse est {0}", answer);
        }
    }
}
