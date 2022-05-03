using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.BaigiamasisDarbas.PageBaigiamasis
{
    class BaigiamasisPage : BasePageBaigiamasis
    {
        private const string PageAddress = "https://demoqa.com/checkbox";

        public BaigiamasisPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
    }
}
