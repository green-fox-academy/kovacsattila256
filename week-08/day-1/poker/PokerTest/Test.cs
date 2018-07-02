using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PokerHandsTest
{
    [TestFixture]
    class Test
    {
        [TestCase]
        public void TestMethod1()
        {
            int input = 5;
            Assert.AreEqual(5, input);
        }
    }
}
