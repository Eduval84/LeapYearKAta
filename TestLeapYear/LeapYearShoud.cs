using LeapYearKata;
using Xunit;

namespace TestLeapYear
{
    public class LeapYearShoud
    {
        [Theory]
        [InlineData(1996,true)]
        [InlineData(1600, true)]
        [InlineData(1997,false)]
        [InlineData(1800, false)]
        public void check_If_its_a_leap_year(int input, bool expectedResult)
        {
            bool result = LeapYear.checkIfYearIsLeap(input);
            Assert.Equal(result, expectedResult);

        }
    }
}
