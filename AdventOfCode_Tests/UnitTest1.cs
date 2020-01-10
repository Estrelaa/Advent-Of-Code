using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Day_4;

namespace AdventOfCode_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Day_4 day4 = new Day_4();

            day4.PartOne(111111);
        }
    }
}
