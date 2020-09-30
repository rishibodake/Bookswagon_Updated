using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Bookswagon_Updated.Pages
{
    public class ShippingAddress
    {
        public ShippingAddress(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewRecipientName")]
        public IWebElement name;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewCompanyName")]
        public IWebElement companyname;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewAddress")]
        public IWebElement streetaddress;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ddlNewState")]
        public IWebElement state;

        [FindsBy(How = How.XPath, Using = "//option[@value='MH']")]
        public IWebElement MH;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewCity")]
        public IWebElement city;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewPincode")]
        public IWebElement pincode;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewMobile")]
        public IWebElement mobile;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_imgSaveNew")]
        public IWebElement saveandcontinue;
    }
}
