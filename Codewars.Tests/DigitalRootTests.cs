using NUnit.Framework;

namespace Codewars.Tests
{
    class DigitalRootTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(7, DigitalRoot.SumOfDigits(16));
            Assert.AreEqual(6, DigitalRoot.SumOfDigits(456));
        }
    }
}
