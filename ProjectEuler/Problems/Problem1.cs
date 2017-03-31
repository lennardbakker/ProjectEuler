using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem1
    {
        public Problem1()
        {
            var _limit = 1000;
            var _sum = 0;

            //We loop till we have reached the limit, if 'i' is not a multiple of 3 OR 5 the 'i' doesn't get added to the sum
            for(int i = 1; i < _limit; i++)
            {
                if (i % 3 == 0)
                {
                    _sum += i;
                }
                else if (i % 5 == 0)
                {
                    _sum += i;
                }
            }
            Console.WriteLine(_sum);
            Console.ReadKey();
        }
    }
}
