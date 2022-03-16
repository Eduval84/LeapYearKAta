using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearKata
{
    public class LeapYear
    {
        static void Main(string[] args)
        {
        }

        public static bool CheckIfDateIsDivisibleBy4(int input)
        {
            return (input % 4 == 0);
        }

        public static bool CheckIfDateIsDivisibleBy100(int input)
        {
            return true;
        }
    }
}
