using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VCSPavasaris
{
    class FirstTest
    {
        [Test]
        public static void TestIf4IsEven()
        {
            int leftOver = 4 % 2;

            Assert.AreEqual(0, leftOver, "4 is not even");

        }
        [Test]
        public static void TestNowIs19()
        {
            DateTime currentTime = DateTime.Now;

            Assert.AreEqual(19, currentTime.Hour, currentTime.ToString());
        }
        [Test]
        public static void DalybaIs3()
        {
            int dalIs3 = 995 % 3;

            Assert.AreEqual(0, dalIs3, "995 nesidalina is 3 be liekanos");
        }
        [Test]
        public static void TestNowIsMonday()
        {
            DateTime currentTime = DateTime.Now;

            Assert.AreEqual(DayOfWeek.Monday, currentTime.DayOfWeek, "Siandien ne pirmadienis");
        }
        [Test]
        public static void TestWait()
        {
            Thread.Sleep(2000);
        }

    }
}
