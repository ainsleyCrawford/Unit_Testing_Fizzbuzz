using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMethod
{
    public class FBClass
    {
        public string FizzBuzzProgram(int value)
        {
            if (value % 3 == 0 & value % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (value % 3 == 0)
            {
                return "Fizz";
            }
            else if (value % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
