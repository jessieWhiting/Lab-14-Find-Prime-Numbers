using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab_14_Find_Prime_Numbers
{
    public class PrimeNumberTest
    {
        [Fact]
        public void TestPrime()
        {
            //arrange
            PrimeNumber pn = new PrimeNumber();
            string expected = "{0} is a Prime Number";

            //act
            string actual = pn.GetPrime(3);

            //assert
            Assert.Equal(expected, actual);
        }

        public void TestIsNotPrime()
        {
            PrimeNumber pn = new PrimeNumber();

            string expected = "Not a Prime Number";

            string actual = pn.GetPrime(1);

        }

        [Theory]
        [InlineData(53, "{0} is a Prime Number")]
        [InlineData(5, "{0} is a Prime Number")]
        [InlineData(23, "{0} is a Prime Number")]
        [InlineData(11, "{0} is a Prime Number")]
        [InlineData(88, "Not a Prime Number")]
        [InlineData(4, "Not a Prime Number")]
        [InlineData(12, "Not a Prime Number")]
        [InlineData(42, "Not a Prime Number")]



        public void TestAll(int input, string expected)
        {
            //arrange
            PrimeNumber pn = new PrimeNumber();

            //act
            string actual = pn.GetPrime(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
