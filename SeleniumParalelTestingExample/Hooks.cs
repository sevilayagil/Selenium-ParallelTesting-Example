using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumParalelTestingExample
{
    [TestFixture]
     public class Hooks:Base
    {
        public Hooks()
        {
            Driver = new FirefoxDriver();
        }
    }
}
