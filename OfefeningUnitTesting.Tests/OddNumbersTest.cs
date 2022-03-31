using NUnit.Framework;
using OefeningUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfefeningUnitTesting.Tests
{
    public class OddNumbersTest
    {
        [Test]
        public void GetOddNumbers_Test()
        {
            OddNumbers oddNumbers = new OddNumbers();
            var result = oddNumbers.GetOddNumbers(5);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
        }
    }
}
