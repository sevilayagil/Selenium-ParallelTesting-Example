using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumParalelTestingExample
{
    [TestFixture]
    public class FirefoxTesting :Hooks
    {
        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com"); 
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Driver.FindElement(By.Name("btnG")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"),Is.EqualTo(true),
                "The text selenium doesnt exist");
        }
    }
    [TestFixture]
    public class ChromeTesting:Hooks
    {
        [Test]
        public void ChromeGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("sevilay");
            Driver.FindElement(By.Name("btnG")).Click();
            Assert.That(Driver.PageSource.Contains("sevilay"), Is.EqualTo(true),
                "The text selenium doesnt exist");
        }
    }
}
