using FinalTry.POM.Core;
using FinalTry.POM.SOURCECODE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.ABOUT_PAGE
{
    [TestClass]
    public class AboutTestCase
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "CLickOnAboutPage", DataAccessMethod.Sequential)]

        public void CLickOnAboutPage()
        {
            AboutClass aboutpage = new AboutClass();
            string url = TestContext.DataRow["url"].ToString();
            string abt = TestContext.DataRow["abt"].ToString();
            BasePage.seleniumInit();
            aboutpage.About(url);
            
            BasePage.driverClose();

        }
    }
}
