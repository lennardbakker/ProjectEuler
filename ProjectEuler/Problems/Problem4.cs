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
            var _highestFound = 0;

            for (int i = _threeDigitRange; i >= _firstProduct; i--)
            {
                for (int j = _threeDigitRange; j >= _secondProduct; j--)
                {
                    int _sum = i * j;
                    string _sumString = _sum.ToString();

                    if (isPalindrome(_sumString) && (_sum > _highestFound))
                    {
                        _highestFound = _sum;
                    }

                }
            }
            Console.WriteLine(_highestFound);
            Console.ReadKey();
        }

        public bool isPalindrome(string myString)
        {
            string _first = myString.Substring(0, myString.Length / 2);
            char[] _arr = myString.ToCharArray();
            Array.Reverse(_arr);
            string _temp = new string(_arr);
            string _second = _temp.Substring(0, _temp.Length / 2);

            return _first.Equals(_second);
        }
    }
}
