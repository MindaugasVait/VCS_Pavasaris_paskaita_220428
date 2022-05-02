using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSPavasaris.Page;

namespace VCSPavasaris.Test
{
    class ND3MiVaTest220502
    {
        private static IWebDriver _driver;
        public static void OneTimeSetup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        /*public static void OneTimeTearDown()
        {
            _driver.Quit();
        }*/
        [Test]
        public static void CheckBoxClickTest()
        {
            

            ND3MiVaPage220502 checkBoxClickTest = new ND3MiVaPage220502(_driver);

            checkBoxClickTest.NavigateToDefaultPage();
            checkBoxClickTest.ClickExpandAllButton();

        }
    }
}
