using Bookswagon_Updated.DoActions;
using NUnit.Framework;

namespace Bookswagon_Updated
{
    [TestFixture]
    public class TestClass : BaseClass
    {     
        [Test]
        public void LoginTest()
        {
            DoAction.Login(driver);
        }
        [OneTimeTearDown]
        public void CloseUp()
        {
            driver.Quit();
        }
    }
}
