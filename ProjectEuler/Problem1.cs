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
            var _below = 1000;
            var sum = 0;
            for(int i = 1; i < _below; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
