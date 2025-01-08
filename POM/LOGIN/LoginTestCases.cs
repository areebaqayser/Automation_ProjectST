using FinalTry.POM.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.LOGIN
{
    [TestClass]
    public class LoginTestCases
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "LoginWithValidUserValidPass", DataAccessMethod.Sequential)]
        //css selector of User name displayed: #logoutForm > ul > li:nth-child(1)
        //css selector of logoff: #logoutForm > ul > li:nth-child(2)
        public void LoginWithValidUserValidPass()
        {
            LoginClass loginpage = new LoginClass();
            string url = TestContext.DataRow["url"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string value = TestContext.DataRow["value"].ToString();

            BasePage.seleniumInit();
            loginpage.login(url, username, password);
            string val = BasePage.driver.FindElement(LoginClass.displayname).Text;
            Assert.AreEqual(value, val);
            BasePage.driverClose();

        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "LoginWithCheckboxChecked", DataAccessMethod.Sequential)]
        
        public void LoginWithCheckboxChecked()
        {
            LoginClass loginpage = new LoginClass();
            string url = TestContext.DataRow["url"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string value = TestContext.DataRow["value"].ToString();

            BasePage.seleniumInit();
            loginpage.checkbox(url, username, password);
            string val = BasePage.driver.FindElement(LoginClass.displayname).Text;
            Assert.AreEqual(value, val);
            BasePage.driverClose();

        }

        //invalid username & password
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "LoginWithInValidUserInValidPass", DataAccessMethod.Sequential)]

        public void LoginWithInValidUserInValidPass()
        {
            LoginClass loginpage = new LoginClass();

            string url = TestContext.DataRow["url"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string errormsg = TestContext.DataRow["errormsg"].ToString();
            BasePage.seleniumInit();
            loginpage.login(url, username, password);
            string val = BasePage.driver.FindElement(LoginClass.errormsg).Text;
            Assert.AreEqual(errormsg, val);
            BasePage.driverClose();
        }

        //login leaving username & password fields empty
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "LoginWithEmptyFields", DataAccessMethod.Sequential)]

        public void LoginWithEmptyFields()
        {
            LoginClass loginpage = new LoginClass();

            string url = TestContext.DataRow["url"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string req1 = TestContext.DataRow["req1"].ToString();
          //  string req2 = TestContext.DataRow["req2"].ToString();
            BasePage.seleniumInit();
            loginpage.login(url, username, password);
            string val = BasePage.driver.FindElement(LoginClass.req1).Text;
            Assert.AreEqual(req1, val);
          /*  string val2 = BasePage.driver.FindElement(LoginClass.req2).Text;
            Assert.AreEqual(req2, val2);*/
            BasePage.driverClose();
        }

        /*
        

        //Searching an Existing Employee
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "SearchEmployeeSuccess", DataAccessMethod.Sequential)]

        public void SearchEmployeeSuccess()
        {
            var driver = new ChromeDriver();
            string url = TestContext.DataRow["url"].ToString();
            string employeelist = TestContext.DataRow["employeelist"].ToString();
            string search = TestContext.DataRow["search"].ToString();
            string find = TestContext.DataRow["find"].ToString();

            driver.Url = url;
            driver.Manage().Window.Maximize();
            EmployeeSearchClass emp = new EmployeeSearchClass(driver);
            emp.click();
            emp.search(search);
            var actualEmployee = driver.FindElement(By.CssSelector("body > div.container.body-content > table > tbody > tr:nth-child(3) > td:nth-child(1)")).Text;
            Assert.AreEqual(find, actualEmployee);
            emp.Quit();
        }

        //Searching a Non-Existing Employee
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "SearchEmployeeFailed", DataAccessMethod.Sequential)]

        public void SearchEmployeeFailed()
        {
            var driver = new ChromeDriver();
            string url = TestContext.DataRow["url"].ToString();
            string employeelist = TestContext.DataRow["employeelist"].ToString();
            string search = TestContext.DataRow["search"].ToString();
            string find = TestContext.DataRow["find"].ToString();

            driver.Url = url;
            driver.Manage().Window.Maximize();
            EmployeeSearchClass emp = new EmployeeSearchClass(driver);
            emp.click();
            emp.search(search);
            //   emp.Quit();
        }

        

        //Registeration Failed leaving username field empty
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "RegisterFailed", DataAccessMethod.Sequential)]

        public void RegisterFailed()
        {
            var driver = new ChromeDriver();
            string url = TestContext.DataRow["url"].ToString();
            string register = TestContext.DataRow["register"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirm = TestContext.DataRow["confirm"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string msg = TestContext.DataRow["msg"].ToString();

            driver.Url = url;
            driver.Manage().Window.Maximize();
            LoginClass reg = new LoginClass(driver);
            reg.register(username, password, confirm, email);
            var errormsg = driver.FindElement(By.CssSelector("body > div.container.body-content > form > div.text-danger.validation-summary-errors > ul > li:nth-child(1)\r\n            ")).Text;
            Assert.AreEqual(msg, errormsg);
            reg.Quit();
        }*/


    }
}
