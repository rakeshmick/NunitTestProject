using NUnit.Framework;

namespace NunitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(false);
        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            Assert.Pass();
        }
    }
}
