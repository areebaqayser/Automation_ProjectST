using FinalTry.POM.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.PASSWORD
{
    [TestClass]
    public class ChangePasswordTestCasecs
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "PasswordChangesSuccessfully", DataAccessMethod.Sequential)]
        
        public void PasswordChangesSuccessfully()
        {
            ChangePasswordClass changepass = new ChangePasswordClass();
            string url = TestContext.DataRow["url"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string value = TestContext.DataRow["value"].ToString();
            string current = TestContext.DataRow["current"].ToString();
            string newpass = TestContext.DataRow["newpass"].ToString();
            string confirm = TestContext.DataRow["confirm"].ToString();

            BasePage.seleniumInit();
            changepass.change(url, username, password, newpass, confirm);
            /*string val = BasePage.driver.FindElement(LoginClass.displayname).Text;
            Assert.AreEqual(value, val);*/
            BasePage.driverClose();

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "ConfirmPass_And_NewPass_Unmatched", DataAccessMethod.Sequential)]

        public void ConfirmPass_And_NewPass_Unmatched()
        {
            ChangePasswordClass changepass = new ChangePasswordClass();
            string url = TestContext.DataRow["url"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string value = TestContext.DataRow["value"].ToString();
            string current = TestContext.DataRow["current"].ToString();
            string newpass = TestContext.DataRow["newpass"].ToString();
            string confirm = TestContext.DataRow["confirm"].ToString();

            BasePage.seleniumInit();
            changepass.change(url, username, password, newpass, confirm);
            /*string val = BasePage.driver.FindElement(ChangePasswordClass.errormsg1).Text;
            Assert.AreEqual(value, val);*/
            BasePage.driverClose();

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "Setting_Single_Character_Password", DataAccessMethod.Sequential)]

        public void Setting_Single_Character_Password()
        {
            ChangePasswordClass changepass = new ChangePasswordClass();
            string url = TestContext.DataRow["url"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string value = TestContext.DataRow["value"].ToString();
            string current = TestContext.DataRow["current"].ToString();
            string newpass = TestContext.DataRow["newpass"].ToString();
            string confirm = TestContext.DataRow["confirm"].ToString();

            BasePage.seleniumInit();
            changepass.change(url, username, password, newpass, confirm);
            /*string val = BasePage.driver.FindElement(LoginClass.displayname).Text;
            Assert.AreEqual(value, val);*/
            BasePage.driverClose();

        }
        
    }
}
