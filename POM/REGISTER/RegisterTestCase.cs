using FinalTry.POM.Core;
using FinalTry.POM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.REGISTER
{
    [TestClass]
    public class RegisterTestCase
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        //Register Successfully
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "RegisterWithValidCredentials", DataAccessMethod.Sequential)]

        public void RegisterWithValidCredentials()
        {
            RegisterClass reg = new RegisterClass();
            string url = TestContext.DataRow["url"].ToString();
            string register = TestContext.DataRow["register"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirm = TestContext.DataRow["confirm"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            BasePage.seleniumInit();
            reg.register(url, register, username, password, confirm, email);
            //string val = BasePage.driver.FindElement(RegisterClass.displayname).Text;

            BasePage.driverClose();

            // reg.Quit();
        }

        //Registeration Failed
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "RegisterLeavingUsernameEmpty", DataAccessMethod.Sequential)]

        public void RegisterLeavingUsernameEmpty()
        {
            RegisterClass reg = new RegisterClass();
            string url = TestContext.DataRow["url"].ToString();
            string register = TestContext.DataRow["register"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirm = TestContext.DataRow["confirm"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string msg = TestContext.DataRow["msg"].ToString();
            BasePage.seleniumInit();
            reg.register(url, register, username, password, confirm, email);
            string val = BasePage.driver.FindElement(RegisterClass.displayname).Text;
            Assert.AreEqual(msg, val);
            BasePage.driverClose();

            // reg.Quit();
        }

        
    }
}
