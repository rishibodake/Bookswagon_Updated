using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Bookswagon_Updated.Pages
{
    public class ShoppingCart
    {
        public ShoppingCart(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='shippingoption.aspx']")]
        public IWebElement continueTo;
    }
}
