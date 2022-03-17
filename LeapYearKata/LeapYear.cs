using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearKata
{
    public class LeapYear
    {
        private static void Main(string[] args)
        {
        }

        public static bool checkIfYearIsLeap(int input)
        {
            if (CheckIfDateIsDivisibleBy400(input))
                return true;

            return CheckIfDateIsDivisibleBy4(input) && !CheckIfDateIsDivisibleBy100(input);
        }

        public static bool CheckIfDateIsDivisibleBy4(int input)
        {
            return (input % 4 == 0);
        }

        public static bool CheckIfDateIsDivisibleBy100(int input)
        {
            return (input % 100 == 0);
        }

        public static bool CheckIfDateIsDivisibleBy400(int input)
        {
            return (input % 400 == 0);
        }
    }
}
