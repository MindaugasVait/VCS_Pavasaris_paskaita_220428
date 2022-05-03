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
    class ND1_220427
    {
        [Test]
        public static void TestSum1()
        {
            //Testuojama suma 2+2:
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            int fN, sN, sum;
            fN = 2;
            sN = 2;
            sum = fN + sN;

            IWebElement firstNoInput = driver.FindElement(By.Id("number1"));
            firstNoInput.SendKeys(Convert.ToString(fN));
            IWebElement secondNoInput = driver.FindElement(By.Id("number2"));
            secondNoInput.SendKeys(Convert.ToString(sN));
            IWebElement calcButton = driver.FindElement(By.Id("calculate"));
            calcButton.Click();
            IWebElement sumResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual(Convert.ToString(sum), sumResult.Text, "Calculator is not working!");
            driver.Quit();
        }

        [Test]
        public static void TestSum2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            int fN, sN, sum;
            fN = -5;
            sN = 3;
            sum = fN + sN;

            IWebElement firstNoInput = driver.FindElement(By.Id("number1"));
            firstNoInput.SendKeys(Convert.ToString(fN));
            IWebElement secondNoInput = driver.FindElement(By.Id("number2"));
            secondNoInput.SendKeys(Convert.ToString(sN));
            IWebElement calcButton = driver.FindElement(By.Id("calculate"));
            calcButton.Click();
            IWebElement sumResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual(Convert.ToString(sum), sumResult.Text, "Calculator is not working!");
            driver.Quit();
        }

        [Test]
        public static void TestSumText()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";           

            IWebElement firstNoInput = driver.FindElement(By.Id("number1"));
            firstNoInput.SendKeys("a");
            IWebElement secondNoInput = driver.FindElement(By.Id("number2"));
            secondNoInput.SendKeys("b");
            IWebElement calcButton = driver.FindElement(By.Id("calculate"));
            calcButton.Click();
            IWebElement sumResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("ERR", sumResult.Text, "Calculator is not working!");
            driver.Quit();
        }
        
        [Test]
        public static void TestMinus()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            int fN, sN, minus;
            fN = 2;
            sN = 2;
            minus = fN - sN;

            IWebElement firstNoInput = driver.FindElement(By.Id("number1"));
            firstNoInput.SendKeys(Convert.ToString(fN));
            IWebElement actioninput = driver.FindElement(By.Id("function"));
            IWebElement pasirinkimas = driver.FindElement(By.CssSelector("#function > option:nth-child(3)"));
            pasirinkimas.Click();
            IWebElement secondNoInput = driver.FindElement(By.Id("number2"));
            secondNoInput.SendKeys(Convert.ToString(sN));
            IWebElement calcButton = driver.FindElement(By.Id("calculate"));
            calcButton.Click();
            IWebElement sumResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual(Convert.ToString(minus), sumResult.Text, "Calculator is not working!");
            
        }
    }
}
