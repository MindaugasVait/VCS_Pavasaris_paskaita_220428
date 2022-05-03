using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.BaigiamasisDarbas.TestBaigiamasis
{
    class TestBaigiamasis : BaseTestBaigiamasis
    {
        [Test]

        public static void TestExpandAllButton()
        {
            _baigiamasisPage.NavigateToDefaultPage();
            
        }
    }
}
