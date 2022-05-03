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
    class Uzduotis2_220427
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Url = "https://testsheepnz.github.io/BasicCalculator.html#main-body";
        }

        [TestCase("25", "25.5", "50.5", false, TestName = "25+25,5=50,5 int disabled")]
        [TestCase("5", "25.5", "30", true, TestName = "5+25,5=30 int enabled")]
        [TestCase("1.99", "0.959", "2.949", false,  TestName = "1,99+0,959=2,949 int disabled")]
        [TestCase("-1", "-9.99", "-10", true,  TestName = "-1+-9,99=-10 int enabled")]
        public static void TestSum(string firstValue, string secondValue, string expectedResult, bool isIntegersEnabled)
        {
            IWebElement firstNoInput = driver.FindElement(By.Name("number1"));
            firstNoInput.Clear();
            firstNoInput.SendKeys(firstValue);
            
            IWebElement secondNoInput = driver.FindElement(By.Name("number2"));
            secondNoInput.Clear();
            secondNoInput.SendKeys(secondValue);
            
            IWebElement integersOnlyCheckBox = driver.FindElement(By.Id("integerSelect"));
            if (isIntegersEnabled != integersOnlyCheckBox.Selected)
            {
                integersOnlyCheckBox.Click();
            }
            
            IWebElement calcButton = driver.FindElement(By.Id("calculateButton"));
            calcButton.Click();
            
            IWebElement actualResult = driver.FindElement(By.Name("numberAnswer"));
            Assert.AreEqual(expectedResult, actualResult.GetAttribute("value").ToString(), "Calculator is not working!");

        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}
