using NUnit.Framework;
using OefeningUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfefeningUnitTesting.Tests
{
    public class OmdraaienTest
    {
        [Test]
        [TestCase(2135, 5312)]
        [TestCase(35, 53)]
        [TestCase(222, 222)]
        public void Oefeningen_ReverseDigits_ReturnReversed(int number, int expected)
        {
            Omdraaien omdraaien = new Omdraaien();
            var actual = omdraaien.ReverseTheDigits(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
