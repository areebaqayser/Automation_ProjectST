using FinalTry.POM.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.LOGOUT
{
    [TestClass]
    public class Logouttestcase
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "UserlogoutSuccessfully", DataAccessMethod.Sequential)]
        //css selector of User name displayed: #logoutForm > ul > li:nth-child(1)
        //css selector of logoff: #logoutForm > ul > li:nth-child(2)
        public void UserlogoutSuccessfully()
        {
            LogoutClass logoutpage = new LogoutClass();
            string url = TestContext.DataRow["url"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string logout = TestContext.DataRow["logout"].ToString();

            BasePage.seleniumInit();
            logoutpage.logout(url, username, password);
          //  string val = BasePage.driver.FindElement(LoginClass.displayname).Text;
           // Assert.AreEqual(value, val);
            BasePage.driverClose();

        }



    }
}
