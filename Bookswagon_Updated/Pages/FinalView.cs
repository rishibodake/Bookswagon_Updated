using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace Bookswagon_Updated.Pages
{
    public class FinalView
    {
        public FinalView(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ShoppingCart_lvCart_txtGiftMessage")]
        public IWebElement giftmessage;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ShoppingCart_lvCart_txtInstruction")]
        public IWebElement instruction;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ShoppingCart_lvCart_savecontinue")]
        public IWebElement save;
    }
}
