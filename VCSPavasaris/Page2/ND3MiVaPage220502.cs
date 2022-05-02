using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Page2
{
    class ND3MiVaPage220502
    {
        private static IWebDriver _driver;
        private static IWebElement _expandAllButton => _driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all > svg"));
        private static IWebElement _clickCommandsCheckBox => _driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(1) > ol > li:nth-child(2) > span > label"));
        private static IWebElement _commandsResult => _driver.FindElement(By.Id("result"));
        private static IWebElement _clickDesktopCheckBox => _driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(1) > span > label"));
        private static IWebElement _clickDownloadsCheckBox => _driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(3) > span > label"));

        public ND3MiVaPage220502(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        public void NavigateToDefaultPage()
        {
            _driver.Url = "https://demoqa.com/checkbox";
        }

        public void ClickExpandAllButton()
        {
            _expandAllButton.Click();
        }

        public void ClickCommandsCheckBox()
        {
            _clickCommandsCheckBox.Click();
        }
        public void ClickDesktopCheckBox()
        {
            _clickDesktopCheckBox.Click();
        }
        public void ClickDownloadsCheckBox()
        {
            _clickDownloadsCheckBox.Click();
        }

        public void VerifyFirstTaskResult(string expectedResult)
        {
            Assert.AreEqual($"You have selected : {expectedResult}", _commandsResult.Text, "Wrong checkbox selected!");
        }
        public void VerifySecondTaskResult(string expectedResult)
        {
            Assert.AreEqual($"You have selected : {expectedResult}", _commandsResult.Text, "Wrong checkbox selected!");
        }
    }
}
