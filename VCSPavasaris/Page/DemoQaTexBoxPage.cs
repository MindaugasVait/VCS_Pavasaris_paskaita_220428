﻿using NUnit.Framework;
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
    class DemoqaTextBoxPage : BasePage
    {
        private const string PageAdress = "https://demoqa.com/text-box";
        private static IWebElement _fullNameInput => Driver.FindElement(By.Id("userName"));
        private static IWebElement _submitButton => Driver.FindElement(By.CssSelector("#submit"));
        private static IWebElement _nameResult => Driver.FindElement(By.Id("name"));
        private static IWebElement _popup => Driver.FindElement(By.Id("close-fixedban"));

        public DemoqaTextBoxPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAdress;
        }

        public void ClosePopUp()
        {
            GetWait(10).Until(d => _popup.Displayed);
            _popup.Click();
        }

        public void InsertTextToFullNameField(string fullName)
        {
            _fullNameInput.Clear();
            _fullNameInput.SendKeys(fullName);
        }

        public void ClickSubmitButton()
        {
            _submitButton.Click();
        }

        public void VerifyFullNameResult(string expectedResult)
        {
            Assert.AreEqual($"Name:{expectedResult}", _nameResult.Text, "Name is wrong!");
        }
    }
}
