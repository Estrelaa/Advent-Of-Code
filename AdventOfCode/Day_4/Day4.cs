using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode.Day_4
{
    public class Day_4
    {
        public void PartOne()
        {
            // ^([^1]*11[^1]*)
            Regex rx = new Regex("^(1*2*3*4*5*6*7*8*9*$)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex Double = new Regex("^[^1]*11[^1]*$" +
                "|^[^2]*22[^2]*$" +
                "|^[^3]*33[^3]*$" +
                "|^[^4]*44[^4]*$" +
                "|^[^5]*55[^5]*$" +
                "|^[^6]*66[^6]*$" +
                "|^[^7]*77[^7]*$" +
                "|^[^8]*88[^8]*$" +
                "|^[^9]*99[^9]*$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            //Regex TooMany = new Regex("(111|222|333|444|555|666|777|888|999)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            int minRange = 367479;
            int maxRange = 893698;
            string curentValue = minRange.ToString();
            int Counter = 0;

            for (int i = minRange; i < maxRange; i++)
            {
                curentValue = i.ToString();
                Match EveryNumberHigherThanTheLast = rx.Match(curentValue);
                Match TwoMatchingDigits = Double.Match(curentValue);
                //Match TooManyMatchingDigits = TooMany.Match(curentValue);

                if (EveryNumberHigherThanTheLast.Success && TwoMatchingDigits.Success)
                {
                    Counter++;
                }
            }

            Console.WriteLine(Counter);
        }
    }
}
