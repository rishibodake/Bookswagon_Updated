using Bookswagon_Updated.Pages;
using OpenQA.Selenium;
using System.Threading;

namespace Bookswagon_Updated.DoActions
{
    public static class DoAction
    {
        public static void Login(IWebDriver driver)
        {
            LoginPage page = new LoginPage(driver);
            page.username.SendKeys("rishibodake20@gmail.com");
            page.password.SendKeys("jocky1234#");
            page.loginbutton.Click();
        }

        public static void SearchBook(IWebDriver driver)
        {
            HomePage page = new HomePage(driver);
            page.searchbar.SendKeys("Harry Potter" + Keys.ArrowDown + Keys.Enter);
        }

        public static void SelectBook(IWebDriver driver)
        {
            SearchResult page = new SearchResult(driver);
            ShoppingCart CartPage = new ShoppingCart(driver);
            page.book.Click();
            page.buynow.Click();
            Thread.Sleep(10000);
            driver.SwitchTo().Frame(page.myframe);
            page.placeorder.Click();
            Thread.Sleep(5000);
            CartPage.continueTo.Click();
        }

        public static void Address(IWebDriver driver)
        {
            ShippingAddress page = new ShippingAddress(driver);
            page.name.SendKeys("Rishikesh");
            page.streetaddress.SendKeys("Karad Road");
            page.state.Click();
            page.MH.Click();
            page.city.SendKeys("Vita");
            page.pincode.SendKeys("415311");
            page.mobile.SendKeys("2525252525");
            page.saveandcontinue.Click();
        }

        public static void FinalView(IWebDriver driver)
        {
            FinalView page = new FinalView(driver);
            page.save.Click();
        }
       
    }
}
