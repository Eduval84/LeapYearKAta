using LeapYearKata;
using Xunit;

namespace TestLeapYear
{
    public class LeapYearShoud
    {
        [Theory]
        [InlineData(1996,true)]
        [InlineData(1997,false)]
        public void Year_Its_a_leap_year_if_inputYear_is_divisible_by_4(int input, bool expectedResult)
        {
            bool result = LeapYear.CheckIfDateIsDivisibleBy4(input);
            Assert.Equal(result, expectedResult);

        }

        [Fact]
        public void Year_Its_a_leap_year_if_inputYear_is_divisible_by_400()
        {
            var input = 1600;
            bool result = LeapYear.CheckIfDateIsDivisibleBy400(input);
            Assert.Equal(result, true);

        }

        [Fact]
        public void Year_1500_Its_Not_a_leap_year_because_is_divisible_by_100_but_not_divisible_by_400()
        {
            var input = 1500;
            bool result = LeapYear.CheckIfDateIsDivisibleBy100ButNotBy400(input);
            Assert.Equal(result, true);

        }

        [Fact]
        public void Year_1800_Its_Not_a_leap_year_because_is_divisible_by_4_divisible_by100_but_not_divisible_by_400()
        {
            var input = 1800;
            bool result = LeapYear.CheckIfDateIsDivisibleBy4By100ButNotBy400(input);
            Assert.Equal(result, true);

        }

    }
}
