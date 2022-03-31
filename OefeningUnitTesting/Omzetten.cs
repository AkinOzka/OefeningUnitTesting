using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningUnitTesting
{
    public class Omzetten
    {
        public string LastDigitToString(int number)
        {
            string[] numbersInWords = new string[10] {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight","Nine"};                            
            var lastnumber = number % 10;
            return numbersInWords[lastnumber];
        }
    }
}
