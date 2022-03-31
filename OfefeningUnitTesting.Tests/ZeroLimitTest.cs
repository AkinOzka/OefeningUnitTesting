using NUnit.Framework;
using OefeningUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfefeningUnitTesting.Tests
{
    public class ZeroLimitTest
    {
        [Test]
        public void Oefeningen_GetNumbersBetweenZerotoLimit_Test()
        {
            ZeroLimit zeroLimit = new ZeroLimit();
            var result = zeroLimit.GetNumbersBetweenZerotoLimit(4);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
            Assert.That(result, Is.EquivalentTo(new[] { 0, 1, 2, 3 }));
        }
    }
}

