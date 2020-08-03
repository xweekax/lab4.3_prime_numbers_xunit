using lab4._3_Prime_Numbers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace lab4._3_Prime_Numbers_Xunit
{
    public class PrimeNumbersXunit
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(7, true)]
        [InlineData(12, false)]
        public void Test1(int number, bool expected)
        {
            bool res = PrimeNumbers.getPrime(number);
            Assert.Equal(expected, res);
        }
    }
}
