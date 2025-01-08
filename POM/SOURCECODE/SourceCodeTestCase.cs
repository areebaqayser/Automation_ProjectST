using FinalTry.POM.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.SOURCECODE
{
    [TestClass]
    public class SourceCodeTestCase
    {
       
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "RedirectToGithubPage", DataAccessMethod.Sequential)]
        
        public void RedirectToGithubPage()
        {
            SourceCodeClass src = new SourceCodeClass();
            string url = TestContext.DataRow["url"].ToString();
            
            string url2 = TestContext.DataRow["url2"].ToString();
            string git = TestContext.DataRow["git"].ToString();

            BasePage.seleniumInit();
            src.sourcecode(url, url2);
            /*string val = BasePage.driver.FindElement(LoginClass.displayname).Text;
            Assert.AreEqual(value, val);*/
            BasePage.driverClose();

        }
    }
}
