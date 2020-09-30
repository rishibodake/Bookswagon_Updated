using Bookswagon_Updated.DoActions;
using NUnit.Framework;
using System.IO;

namespace Bookswagon_Updated
{
    [TestFixture]
    public class TestClass : BaseClass
    {     
        [Test,Order(0)]
        public void LoginTest()
        {
            DoAction.Login(driver);
        }

        [Test,Order(1)]
        public void SearchTest()
        {
            DoAction.SearchBook(driver);
        }
        [OneTimeTearDown]
        public void CloseUp()
        {
            driver.Quit();
        }
    }
}
