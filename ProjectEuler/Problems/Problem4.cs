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

            //Loop from _threeDigitRange to _firstProduct, within this loop loop from _threeDigitRange to _secondProduct
            //Check if the sum is a palindrome and the sum must be higher then the _highestFound palindrome, if so then set it as the _highestFound palindrome within the loop
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

        //By using the Substring method on the given parameter copy the first half of the string
        //Make the string given as parameter a char array, then reverse the array
        //Copy the first half of the reverted string
        //Return true if _first equals _second
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
