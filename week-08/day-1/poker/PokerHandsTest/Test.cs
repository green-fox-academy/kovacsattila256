using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PokerHandsApp;

namespace PokerHandsTest
{
    [TestFixture]
    public class PokerHandsTest
    {
        Poker poker = new Poker();

        [Test]
        public void CheckIfInputIs12()
        {
            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            bool output = poker.CheckInputLength12(input);
            Assert.AreEqual(true, output);
        }

        [Test]
        public void GetHands()
        {
            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            string output = poker.GetHands(input);
            Assert.AreEqual("White wins", output);
        }

    }
}
