using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumParalelTestingExample
{
     public enum BrowserType
    {
        CHROME,
        FIREFOX,
        IE
    }
    [TestFixture]
     public class Hooks: Base
    {
        private BrowserType _browserType;

        public Hooks(BrowserType browser)
        {
            _browserType = browser; 
        }
        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }
        private void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.CHROME)
                Driver = new ChromeDriver();
            else if (browserType == BrowserType.FIREFOX)
            {
                Driver = new FirefoxDriver();
            }
        }
    }
}
