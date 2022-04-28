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
    class ND2_MV_220428
    {
        [Test]
        public static void TestBegimas()
        {
            //Testuojama ar nubegus 13 km per 1 val. ir 5 min., begimo greitis bus 5 min/km:
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.active.com/fitness/calculators/pace";

            IWebElement firstNoInput = driver.FindElement(By.Name("time_hours"));
            firstNoInput.SendKeys(Convert.ToString(1));
            IWebElement secondNoInput = driver.FindElement(By.Name("time_minutes"));
            secondNoInput.SendKeys(Convert.ToString(5));
            IWebElement ThirdNoInput = driver.FindElement(By.Name("distance"));

            IWebElement distanceBox = driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span > span > span.selectboxit-text"));
            distanceBox.Click();
            IWebElement pasirinkimasKm = driver.FindElement(By.Id("0"));
            pasirinkimasKm.Click();

            /*driver.FindElement(By.CssSelector(".selectboxit-hover")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".selectboxit-focus > .selectboxit-option-anchor"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector(".control-group:nth-child(4) label:nth-child(2)"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.CssSelector(".form-horizontal")).Click();
            driver.FindElement(By.CssSelector(".selectboxit-hover > .selectboxit-text")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".selectboxit-container:nth-child(5) .selectboxit-option-first > .selectboxit-option-anchor"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector(".form-horizontal > .row-fluid:nth-child(6) > .span12"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.CssSelector(".form-horizontal")).Click();
            driver.FindElement(By.CssSelector(".btn-medium-yellow")).Click();
            }

        /*IWebElement firstNoInput = driver.FindElement(By.Id("number1"));
        firstNoInput.SendKeys(Convert.ToString(fN));
        IWebElement secondNoInput = driver.FindElement(By.Id("number2"));

        IWebElement calcButton = driver.FindElement(By.Id("calculate"));
        calcButton.Click();
        IWebElement sumResult = driver.FindElement(By.Id("answer"));
        Assert.AreEqual(Convert.ToString(sum), sumResult.Text, "Calculator is not working!");
        driver.Quit();*/
        }
    }
}
