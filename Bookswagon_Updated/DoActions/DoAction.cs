using Bookswagon_Updated.Pages;
using OpenQA.Selenium;

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
    }
}
