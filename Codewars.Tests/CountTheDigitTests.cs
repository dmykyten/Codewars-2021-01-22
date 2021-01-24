using NUnit.Framework;

namespace Codewars.Tests
{
    public class CountTheDigitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(CountTheDigit.NbDig(5750, 0), 4700);
            Assert.AreEqual(CountTheDigit.NbDig(11011, 2), 9481);
            Assert.AreEqual(CountTheDigit.NbDig(12224, 8), 7733);
            Assert.AreEqual(CountTheDigit.NbDig(11549, 1), 11905);
        }
    }
}