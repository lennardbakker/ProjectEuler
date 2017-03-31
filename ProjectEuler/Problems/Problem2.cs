using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem2
    {
        public Problem2()
        {
            var _maxRange = 4000000;
            var _firstNumber = 1;
            var _secondNumber = 2;

            //If we do not set _sum on 2 before the loop starts it won't add the number 2 from the Fibonacci sequence to the sum
            var _sum = _secondNumber;

            while (_firstNumber + _secondNumber <= _maxRange)
            {
                //Store _firstNumber so we can reuse it making the next number in the Fibonacci sequence
                var _temp = _firstNumber;
                _firstNumber = _secondNumber;
                _secondNumber = _secondNumber + _temp;

                //We only want even numbers added to the sum
                if (_secondNumber % 2 == 0)
                {
                    _sum += _secondNumber;
                }
            }

            Console.WriteLine(_sum);
            Console.ReadKey();
        }
    }
}
