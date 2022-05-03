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
    class CheckBoxTest_220427
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/checkbox";
        }
        [Test]
        public static void  ClickCheckBoxes()
        {
            IWebElement expandAllButton = driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all > svg"));
            expandAllButton.Click();
            IReadOnlyCollection<IWebElement> checkBoxes = driver.FindElements(By.ClassName("rct-checkbox"));

            foreach(IWebElement checkBox in checkBoxes)
            {
                checkBox.Click();
            }
            /* galima naudoti ir for cikla:
            for (int i = 0; i <= checkBoxes.Count; i++)
            {
                checkBoxes.ElementAt(i).Click();
            }
            */

        }
    }
}
