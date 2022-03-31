using NUnit.Framework;
using OefeningUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfefeningUnitTesting.Tests
{
    public class GetMaxTest
    {
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 3, 3)]
        public void Oefeningen_Max_ReturnsGreatestValue(int x, int y, int expected)
        {
            GetMax getMax = new GetMax();
            // Act
            var actual = getMax.Max(x, y);
            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
