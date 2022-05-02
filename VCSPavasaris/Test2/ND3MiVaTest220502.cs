using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSPavasaris.Page2;

namespace VCSPavasaris.Test2
{
    class ND3MiVaTest220502
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }

        /*[OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            _driver.Quit();
        }
        */
        [Test]
        public static void CheckBoxClickTest()
        {
            string expectedResult = "\r\ncommands";
            ND3MiVaPage220502 checkBoxClickTest = new ND3MiVaPage220502(_driver);

            checkBoxClickTest.NavigateToDefaultPage();
            checkBoxClickTest.ClickExpandAllButton();
            checkBoxClickTest.ClickCommandsCheckBox();
            checkBoxClickTest.VerifyFirstTaskResult(expectedResult);
            checkBoxClickTest.ClickCommandsCheckBox();
            checkBoxClickTest.ClickDesktopCheckBox();
            checkBoxClickTest.ClickDownloadsCheckBox();
            expectedResult = "desktop notes commands downloads wordFile excelFile";
            checkBoxClickTest.VerifySecondTaskResult(expectedResult);

        }
        
    }
}
