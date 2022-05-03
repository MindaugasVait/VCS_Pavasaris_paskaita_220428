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
    class ND2_220428
    {
        private static IWebDriver driver;

       public static void Setup(String browserName)
        {
            if (browserName.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (browserName.Equals("fireFox"))
            {
                driver = new FirefoxDriver();
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
        }
        public static IEnumerable<string> BrowserToRunWith()
        {
            String[] browsers = { "chrome", "fireFox" };
            foreach (string b in browsers)
            {
                yield return b;
            }

        }
        [Test]
        [TestCaseSource("BrowserToRunWith")]
        public static void BrowserTest(string browserName)
        {
            Setup(browserName);
            string expectedResult = "";
            if (browserName.Equals("chrome"))
            {
               expectedResult = "Chrome 100 on Windows 10";
            }
            else if (browserName.Equals("fireFox"))
            {
                expectedResult = "Firefox 99 on Windows 10";
            }
            IWebElement actualResult = driver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.AreEqual(expectedResult, actualResult.Text, "Something went wrong!");
            driver.Quit();
        }
       
    }
}
