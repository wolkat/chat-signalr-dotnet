using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ChatServerTest
{
    [TestFixture]
    class SeleniumTest
    {
        [Test]
        public void FirstSeleniumTest()
        {
            var driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.pl");
        }
    }
}
