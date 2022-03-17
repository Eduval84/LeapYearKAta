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
        static void Main(string[] args)
        {
        }

        public static bool CheckIfDateIsDivisibleBy4(int input)
        {
            return (input % 4 == 0);
        }

        public static bool CheckIfDateIsDivisibleBy100(int input)
        {
            return (input % 100 == 0);
        }

        public static bool CheckIfDateIsDivisibleBy100ButNotBy400(int input)
        {
            if (CheckIfDateIsDivisibleBy100(input))
                return !CheckIfDateIsDivisibleBy400(input);
            return true;
        }

        public static bool CheckIfDateIsDivisibleBy400(int input)
        {
            return (input % 400 == 0);
        }

        public static bool CheckIfDateIsDivisibleBy4By100ButNotBy400(int input)
        {
            throw new NotImplementedException();
        }
    }
}
