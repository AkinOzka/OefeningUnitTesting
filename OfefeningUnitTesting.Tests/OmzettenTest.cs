using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OefeningUnitTesting;

namespace OfefeningUnitTesting.Tests
{
    public class OmzettenTest
    {
        [Test]
        [TestCase(0, "Zero")]
       
        public void Oefeningen_LastDigit_ReturnString(int number, string expected)
        {
            Omzetten omzetten = new Omzetten();
            var result = omzetten.LastDigitToString(number);
            Assert.AreEqual(expected, result);
        }
    }
}
