using System;
using LeapYearKata;
using Xunit;

namespace TestLeapYear
{
    public class LeapYearShoud
    {
        [Fact]
        public void Its_a_leap_year_if_input_is_divisible_by_4()
        {
            var input = 4;
            bool result = LeapYear.CheckDate(input);
            Assert.Equal(result,true);

        }
    }
}
