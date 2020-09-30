using NUnit.Framework;

namespace Bookswagon_Updated
{
    [TestFixture]
    public class TestClass : BaseClass
    {     
        [Test]
        public void Test1()
        {

        }
        [OneTimeTearDown]
        public void CloseUp()
        {
            driver.Quit();
        }
    }
}
