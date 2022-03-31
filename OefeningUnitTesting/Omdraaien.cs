using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningUnitTesting
{
    public class Omdraaien
    {
        public int ReverseTheDigits(int number)
        {
            int reverse = 0;
            do
            {
                reverse = reverse * 10 + number % 10;
                number /= 10;
            } while (number > 0);
            return reverse;
        }
    }
}
