using System;
using LeapYearKata;
using Xunit;

namespace TestLeapYear
{
    public class LeapYearShoud
    {
        [Fact]
        public void Year_1996_Its_a_leap_year_if_input_is_divisible_by_4()
        {
            var input = 1996;
            bool result = LeapYear.CheckIfDateIsDivisibleBy4(input);
            Assert.Equal(result,true);

        }

        [Fact]
        public void Year_1600_Its_a_leap_year_because_is_divisible_by_100()
        {
            var input = 1600;
            bool result = LeapYear.CheckIfDateIsDivisibleBy100(input);
            Assert.Equal(result,true);

        }
    }
}
