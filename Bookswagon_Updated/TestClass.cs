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

        [Test,Order(2)]
        public void SelectBook_Test()
        {
            DoAction.SelectBook(driver);
        }

        [Test,Order(3)]
        public void Addresstest()
        {
            DoAction.Address(driver); 
        }

        [Test,Order(4)]
        public void FinalView()
        {
            DoAction.FinalView(driver);
        }
        [OneTimeTearDown]
        public void CloseUp()
        {
            driver.Quit();
        }
    }
}
