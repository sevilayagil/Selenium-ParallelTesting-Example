using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumParalelTestingExample
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxTesting :Hooks
    {
        public FirefoxTesting(): base(BrowserType.FIREFOX)
        {
                
        }
        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.ClassName("gNO89b")).Click();
           Assert.That(Driver.PageSource.Contains("Selenium"),Is.EqualTo(true),
                "The text selenium doesnt exist");
        }
    }
    [TestFixture]
    [Parallelizable]
    public class ChromeTesting:Hooks
    {
        public ChromeTesting() : base(BrowserType.CHROME)
        {

        }
        [Test]
        public void ChromeGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.ClassName("gNO89b")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                "The text selenium doesnt exist");
        } 
    }
}
