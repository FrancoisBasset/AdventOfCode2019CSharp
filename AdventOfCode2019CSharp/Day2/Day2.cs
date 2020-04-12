using System;
using System.IO;

namespace AdventOfCode2019CSharp.Day2
{
    public class Day2
    {
        public static int[] GetIntCode()
        {
            StreamReader reader = new StreamReader("D:/Dev/AdventOfCode2019CSharp/AdventOfCode2019CSharp/Day2/intcode.txt");

            string codesString = reader.ReadLine();
            string[] codes = codesString.Split(',');

            int[] intCode = Array.ConvertAll(codes, c => Int32.Parse(c));//, new Converter<string, int>(codes));

            intCode[1] = 12;
            intCode[2] = 2;

            return intCode;
        }

        public static int[] ExecuteIntCode(int[] intCode)
        {
            int[] newIntCode = (int[]) intCode.Clone();

            int i = 0;

            while (intCode[i] != 99)
            {
                int opCode = newIntCode[i];

                int inputIndex1 = newIntCode[i + 1];
                int inputIndex2 = newIntCode[i + 2];
                int resultIndex = newIntCode[i + 3];

                if (opCode == 1)
                {
                    newIntCode[resultIndex] = newIntCode[inputIndex1] + newIntCode[inputIndex2];
                }

                if (opCode == 2)
                {
                    newIntCode[resultIndex] = newIntCode[inputIndex1] * newIntCode[inputIndex2];
                }

                i += 4;
            }

            return newIntCode;
        }

        public static int[] ExecuteIntCodeWithNounAndVerb(int[] intCode, int noun, int verb)
        {
            intCode[1] = noun;
            intCode[2] = verb;

            intCode = ExecuteIntCode(intCode);

            return intCode;
        }

        public static Tuple<int, int> GetNounAndVerbForIntCode(int[] intCode, int value)
        {
            int[] result;

            for (int noun = 0; noun < intCode.Length; noun++)
            {
                for (int verb = 0; verb < intCode.Length; verb++)
                {   
                    result = ExecuteIntCodeWithNounAndVerb(intCode, noun, verb);

                    if (result[0] == value)
                    {
                        return new Tuple<int, int>(noun, verb);
                    }
                }
            }

            return new Tuple<int, int>(1, 1);
        }
    }
}