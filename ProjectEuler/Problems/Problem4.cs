using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem4
    {
        public Problem4()
        {
            var _firstProduct = 100;
            var _secondProduct = 100;
            var _threeDigitRange = 999;

            for (int i = _threeDigitRange; i >= _firstProduct; i--)
            {
                for (int j = _threeDigitRange; j >= _secondProduct; j--)
                {
                    //If i * j = Palindrome number
                    //Then print sum and break;
                }
            }
           
            Console.ReadKey();
        }
    }
}
