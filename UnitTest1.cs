using System;
using Xunit;
using PrimeNumbersLab;

namespace PrimeNumbersLabTests
{
    public class UnitTest1
    {
        [Theory]

        [InlineData(6, 13)]
        [InlineData(44, 193)]
        [InlineData(59, 277)]
        [InlineData(456, 3221)]
        [InlineData(2345, 20849)]
        public void Test1(int userInput, int expected)
        {
            PrimeNumbers PNums = new PrimeNumbers();
            int result = PNums.GetPrime(userInput);
            Assert.Equal(expected, result);
        }
    }
}
