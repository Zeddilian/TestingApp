using NUnit.Framework;
using System;

namespace TestCase
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            //something new

            Random rnd = new Random();

            int number = rnd.Next(500, 1001);

            Assert.IsTrue(IsInRange(number), "Number is not in the range (600, 900)");
        }

        private bool IsInRange(int number)
        {
            if (number >= 600 && number <= 900)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}