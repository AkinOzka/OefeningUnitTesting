using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningUnitTesting
{
    public class ZeroLimit
    {
        public IEnumerable<int> GetNumbersBetweenZerotoLimit(int limit)
        {
            int[] numbers = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                numbers[i] = i;
            }
            return numbers;
        }
    }
}

