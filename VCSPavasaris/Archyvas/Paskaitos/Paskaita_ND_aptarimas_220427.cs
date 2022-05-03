using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris
{
    class Paskaita_ND_aptarimas_220427
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";
        }

        [TestCase("2", "2", "4", TestName = "2+2=4")]
        [TestCase("-5", "3", "-2", TestName = "-5+3=-2")]
        [TestCase("a", "b", "ERR", TestName = "a+b=ERR")]
        public static void TestSum(string firstValue, string secondValue, string expectedResult)
        {
            IWebElement firstNoInput = driver.FindElement(By.Id("number1"));
            firstNoInput.Clear();
            firstNoInput.SendKeys(firstValue);
            IWebElement secondNoInput = driver.FindElement(By.Id("number2"));
            secondNoInput.Clear();
            secondNoInput.SendKeys(secondValue);
            IWebElement calcButton = driver.FindElement(By.Id("calculate"));
            calcButton.Click();
            IWebElement actualResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual(expectedResult, actualResult.Text, "Calculator is not working!");
            
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}
