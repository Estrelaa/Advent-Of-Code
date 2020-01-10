using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode.Day_1
{
    public class MainDay1
    {
        public static void DayOne()
        {
            var ListOfItems = File.ReadAllLines("DayOne.txt").Select(double.Parse).ToList();

            double temp = 0;
            double MassResult = 0;
            double FuelResult = 0;
            double Total = 0;

            foreach (var item in ListOfItems)
            {
                int fuel = (int)Math.Floor(item / 3) - 2;
                int totalFuel = 0;
                while(fuel > 0)
                {
                    totalFuel += fuel;
                    temp = fuel / 3;
                    temp = Math.Floor(temp);
                    temp -= 2;
                    fuel = (int)temp;

                }
                MassResult += totalFuel;
            }
            Console.WriteLine(MassResult);
        }
    }
}
