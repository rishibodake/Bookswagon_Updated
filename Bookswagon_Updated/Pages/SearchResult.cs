using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Bookswagon_Updated.Pages
{
    public class SearchResult
    {
        public IWebDriver driver;
        public SearchResult(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='https://www.bookswagon.com/book/harry-potter-creatures-bros-warner/9781526605849']")]
        public IWebElement book;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phBody_ProductDetail_divAddtoCart > a > input")]
        public IWebElement buynow;

        [FindsBy(How = How.XPath, Using = "//iframe[@class='cboxIframe']")]
        public IWebElement myframe;


        [FindsBy(How = How.Id, Using = "BookCart_lvCart_imgPayment")]
        public IWebElement placeorder;
    }
}
