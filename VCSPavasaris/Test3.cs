using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris
{
    class Test3
    {
        [Test]
        public static void TestFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://login.yahoo.com/";
            driver.Quit();
        }

    }
}
