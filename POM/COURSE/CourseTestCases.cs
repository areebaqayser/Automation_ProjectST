using FinalTry.POM.Core;
using FinalTry.POM.PASSWORD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.COURSE
{
    [TestClass]
    public class CourseTestCases
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "RedirectToYoutubeChannel", DataAccessMethod.Sequential)]

        public void RedirectToYoutubeChannel()
        {
            CourseClass course = new CourseClass();
            string url = TestContext.DataRow["url"].ToString();
            string url2 = TestContext.DataRow["url2"].ToString();
            string value = TestContext.DataRow["value"].ToString();
            BasePage.seleniumInit();
            course.youtube(url);
            /*string val = BasePage.driver.FindElement(CourseClass.displayname).Text;
            Assert.AreEqual(value, val);*/
            BasePage.driverClose();

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "RedirectToUdemy", DataAccessMethod.Sequential)]

        public void RedirectToUdemy()
        {
            CourseClass course = new CourseClass();
            string url = TestContext.DataRow["url"].ToString();
            string url2 = TestContext.DataRow["url2"].ToString();
            string value = TestContext.DataRow["value"].ToString();
            BasePage.seleniumInit();
            course.udemy(url, url2);
            /*string val = BasePage.driver.FindElement(CourseClass.displayname).Text;
            Assert.AreEqual(value, val);*/
            BasePage.driverClose();

        }

    }
}
