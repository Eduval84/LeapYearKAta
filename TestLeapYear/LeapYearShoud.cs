using LeapYearKata;
using Xunit;

namespace TestLeapYear
{
    public class LeapYearShoud
    {
        [Theory]
        [InlineData(1996,true)]
        [InlineData(1997,false)]
        public void Year_Its_a_leap_year_if_input_is_divisible_by_4(int input, bool expectedResult)
        {
            bool result = LeapYear.CheckIfDateIsDivisibleBy4(input);
            Assert.Equal(result, expectedResult);

        }

        [Fact]
        public void Year_1600_Its_Not_a_leap_year_because_is_divisible_by_100()
        {
            var input = 1600;
            bool result = LeapYear.CheckIfDateIsDivisibleBy100(input);
            Assert.Equal(result,true);

        }

    }
}
