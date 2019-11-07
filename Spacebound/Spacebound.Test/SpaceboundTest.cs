using System;
using NUnit.Framework;
using Spacebound;

namespace Spacebound.Test
{
    [TestFixture]
    public class SpaceboundTest
    {

        Game spacebound;
        [SetUp]
        public void SetUp()
        {
            Game spacebound = new Game();
        }

        [Test]
        public void TestInput()
        {
            string input = Console.ReadLine();
            Assert.AreEqual("Test", input);
        }
    }
}   
