using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Page
{
    class ND3MiVaPage220502
    {
        private static IWebDriver _driver;
        private static IWebElement _expandAllButton => _driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all > svg"));

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
        
    }
}
