using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bookswagon_Updated
{
    public class BaseClass
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Initialise()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("-start-maximized");
            driver = new ChromeDriver(chromeOptions);
            driver.Url = "https://bookswagon.com";
        }
    }
}
