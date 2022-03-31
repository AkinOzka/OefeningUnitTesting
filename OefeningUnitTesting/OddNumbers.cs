using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningUnitTesting
{
    public class OddNumbers
    {
        public IEnumerable<int> GetOddNumbers(int limit)
        {
            List<int> numbers = new List<int>();
            for (var i = 0; i <= limit; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }
    }
}
