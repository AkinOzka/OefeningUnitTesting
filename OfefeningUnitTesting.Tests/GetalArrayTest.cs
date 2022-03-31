using NUnit.Framework;
using OefeningUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfefeningUnitTesting.Tests
{
    public class GetalArrayTest
    {
        [Test]
        [TestCase(2, new int[] { 1, 2, 3, 4, 2 }, 2)]
        public void Oefeningen_CountNumbers_ReturnInArray(int number, int[] array, int expected)
        {
            GetalArray getalArray = new GetalArray();
            var actual = getalArray.CountNumbersInArray(number, array);
            Assert.AreEqual(expected, actual);
        }
    }
}
