using NUnit.Framework;

namespace Codewars.Tests
{
    public class SimpleStringReversalTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("srawedoc", SimpleStringReversal.Solve("codewars"));
            Assert.AreEqual("edoc ruoy", SimpleStringReversal.Solve("your code"));
            Assert.AreEqual("skco redo cruoy", SimpleStringReversal.Solve("your code rocks"));
        }
    }
}
