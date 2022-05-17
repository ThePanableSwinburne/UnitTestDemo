using System;
using UnitTestDemo;
using Xunit;

namespace UnitTestDemoTests
{
    public class BollocksTests
    {
        [Fact]
        public void ConstructorTest()
        {
            Bollocks b = new Bollocks(5, "bollocks1");

            Assert.Equal(5, b.BollNum);
            Assert.Equal("bollocks1", b.BollString);

        }

        [Fact]
        public void AddToTest()
        {
            Bollocks b = new Bollocks(6, "bollocks2");
            int result1 = b.AddTo(10);
            Assert.Equal(16, result1);

            int result2 = b.AddTo(3);
            Assert.Equal(9, result2);

            int result3 = b.AddTo(0);
            Assert.Equal(6, result3);
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(2, 2, 1)]
        [InlineData(10, 3, 3)]
        public void DivByTest(int input, int divisor, int expected)
        {
            Bollocks b = new Bollocks(input, "bollocks2");
            int result = b.DivBy(divisor);
            Assert.Equal(result, expected);

        }

        [Fact]
        public void DivBy_Zero_Test()
        {
            Bollocks b = new Bollocks(6, "bollocks2");

            // try
            // {
            //     int result = b.DivBy(0);
            //     Assert.True(true);
            // }
            // catch (Exception e)
            // {
            //     Assert.True(false);
            //     Console.WriteLine(e);
            //     throw;
            // }



            Assert.Throws<DivideByZeroException>(() => b.DivBy(0));
        }

        [Theory]
        [InlineData(10, 3, 1)]
        [InlineData(8, 3, 2)]
        [InlineData(9, 3, 0)]
        public void ModOfDivByTest(int input, int divisor, int expected)
        {
            Bollocks b = new Bollocks(input, "test");
            var result = b.ModOfDivBy(divisor);
            Assert.Equal(expected, result);
        }
    }
}
