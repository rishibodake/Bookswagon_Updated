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
            Thread.Sleep(10000);
            CartPage.continueTo.Click();
        }
       
    }
}
