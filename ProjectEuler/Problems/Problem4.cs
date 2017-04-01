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

            //vv previous attempt
            //var _top = (999 * 999) + 1;
            //var _biggestPalindrome = 0;

            //while (_top > 0)
            //{
            //    var _reverse = 0;
            //    var _num = _top;

            //    while (_num > 0)
            //    {
            //        var dig = _num % 10;
            //        _reverse = (_reverse * 10) + dig;
            //        _num = _num / 10;
            //    }

            //    if (_num == _reverse)
            //    {
            //        _biggestPalindrome = _top;
            //        Console.WriteLine("Biggest Palindrome : " + _biggestPalindrome);
            //        break;
            //    }

            //    _top--;
            //}

            //Console.ReadKey();
        }
    }
}
