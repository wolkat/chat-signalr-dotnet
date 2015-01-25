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
            //var driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.pl");
            Assert.That(driver.Title,Is.EqualTo("Google"));
            var element = driver.FindElementById("gbqfq");
            element.SendKeys("google\n");
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var result = wait.Until(d => {
                return d.PageSource.Contains("Wyszukiwarka stron WWW");
            });
            Assert.IsTrue(result);
            driver.Quit();
        }
    }
}
