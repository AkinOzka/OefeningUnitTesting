using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OefeningUnitTesting;

namespace OfefeningUnitTesting.Tests
{
    public class HalloTest
    {
        [Test]
        [TestCase("Akin")]
        public void SayHelloReturnsHello(string name)
        {
            Hallo hallo=new Hallo();
            var actual = hallo.GetName(name);
            Assert.AreEqual($"Hello {name}", actual);
        }
    }
}
