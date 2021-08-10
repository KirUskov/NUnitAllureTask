using NUnit.Framework;

namespace AllureNUnitTask
{
    public class MainPage : BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}