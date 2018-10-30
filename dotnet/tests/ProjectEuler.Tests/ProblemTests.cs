using System;
using Xunit;
using ProjectEuler;
namespace ProjectEuler.Tests
{
    public class ProblemTests
    {
        [Fact]
        public void Promlem4_ShouldReturn_906609()
        {
            Assert.Equal(Problem4.LargestThreeDigitPalindrome(),906609);
        }
    }
}
