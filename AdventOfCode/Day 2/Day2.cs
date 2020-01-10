using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Day_2
{
    public class Day2
    {
        public static void DayTwo()
        {
            List<int> test = new List<int> { 1,12,2,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,6,19,2,19,6,23,1,23,5,27,1,9,27,31,1,31,10,35,2,35,9,39,1,5,39,43,2,43,9,47,1,5,47,51,2,51,13,55,1,55,10,59,1,59,10,63,2,9,63,67,1,67,5,71,2,13,71,75,1,75,10,79,1,79,6,83,2,13,83,87,1,87,6,91,1,6,91,95,1,10,95,99,2,99,6,103,1,103,5,107,2,6,107,111,1,10,111,115,1,115,5,119,2,6,119,123,1,123,5,127,2,127,6,131,1,131,5,135,1,2,135,139,1,139,13,0,99,2,0,14,0
 };

            for (int i = 0; i < test.Count; i +=4)
            {
                var temp = 0;
                var postion = 0;

                if (test[i] == 1)
                {
                    temp = test[test[i + 1]] + test[test[i + 2]];
                    postion = test[i + 3];
                    test[postion] = temp;
                }
                else if (test[i] == 2)
                {
                    temp = test[test[i + 1]] * test[test[i + 2]];
                    postion = test[i + 3];
                    test[postion] = temp;
                }
                else if (test[i] == 99)
                {
                    break;
                }
            }
            Console.WriteLine(test[0]);
           
        }
        public static void DayTwoPartTwo()
        {
            List<int> testOriginal = new List<int> { 1,12,2,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,6,19,2,19,6,23,1,23,5,27,1,9,27,31,1,31,10,35,2,35,9,39,1,5,39,43,2,43,9,47,1,5,47,51,2,51,13,55,1,55,10,59,1,59,10,63,2,9,63,67,1,67,5,71,2,13,71,75,1,75,10,79,1,79,6,83,2,13,83,87,1,87,6,91,1,6,91,95,1,10,95,99,2,99,6,103,1,103,5,107,2,6,107,111,1,10,111,115,1,115,5,119,2,6,119,123,1,123,5,127,2,127,6,131,1,131,5,135,1,2,135,139,1,139,13,0,99,2,0,14,0
 };
            var random = new Random();

            while (true)
            {
                var test = new List<int>(testOriginal);
                int test1 = random.Next(0, 100);
                int test2 = random.Next(0, 100);
                test[1] = test1;
                test[2] = test2;

                for (int i = 0; i < test.Count; i += 4)
                {
                    var temp = 0;
                    var postion = 0;
                    try
                    {
                        if (test[i] == 1)
                        {
                            temp = test[test[i + 1]] + test[test[i + 2]];
                            postion = test[i + 3];
                            test[postion] = temp;
                        }
                        else if (test[i] == 2)
                        {
                            temp = test[test[i + 1]] * test[test[i + 2]];
                            postion = test[i + 3];
                            test[postion] = temp;
                        }
                        else if (test[i] == 99)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                if (test[0] == 19690720)
                {
                    Console.WriteLine("");
                    Console.WriteLine("FOUND THE RIGHT COMBO");
                    Console.WriteLine($"Noun = {test[1]}");
                    Console.WriteLine($"Verb = {test[2]}");
                    Console.WriteLine($"100 * noun + verb = {100 * test[1] + test[2]}");
                    break;
                }
                else
                {
                    Console.WriteLine("{0,-2} {1,-2}  {2}",test1, test2, test[0]);
                }
            }
        }
    }
}
