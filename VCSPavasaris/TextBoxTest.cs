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
    class TextBoxTest
    {
        [Test]
        public static void TestInputPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement fullNameInput = driver.FindElement(By.Id("userName"));
            string fullName = "Mindaugas V.";
            fullNameInput.SendKeys(fullName);
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
            IWebElement nameResult = driver.FindElement(By.Id("name"));
            Assert.AreEqual($"Name:{fullName}", nameResult.Text, "Name is wrong!");

            driver.Quit();
        }
    }
}
