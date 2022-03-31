using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningUnitTesting
{
    public class GetalArray
    {
        public int CountNumbersInArray(int number, int[] array)
        {
            int numberOfTimes = 0;
            foreach (var item in array)
            {
                if (item == number)
                {
                    numberOfTimes++;
                }
            }
            return numberOfTimes;
        }
    }
}
