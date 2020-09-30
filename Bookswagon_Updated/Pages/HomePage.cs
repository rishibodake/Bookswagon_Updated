using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace Bookswagon_Updated.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_lihome")]
        public IWebElement home;

        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        public IWebElement searchbar;
    }
}
