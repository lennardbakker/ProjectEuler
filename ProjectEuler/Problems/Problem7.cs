using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem7
    {
        public Problem7()
        {
            int _found = 4;
            int _primeNumber = 0;
            int _number = 2;

            int[] numbers = (1,7,11,13,17,19,23,29, 31,37,41,43,47,49,53,59}

            while (_found < 1000)
            {
                if (!((_number % 2 == 0) || (_number % 3 == 0) || (_number % 5 == 0) || (_number % 7 == 0) || (_number % 11 == 0) || (_number % 13 == 0) || (_number % 17 == 0)))
                {
                    _primeNumber = _number;
                    _found++;
                    Console.WriteLine(_primeNumber + "number: "+ _found);
                    
                }
                _number++;
            }

            Console.WriteLine("final" + _primeNumber);
            Console.ReadKey();
        }
    }
}
