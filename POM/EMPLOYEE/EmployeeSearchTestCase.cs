using FinalTry.POM.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.SEARCH
{
    [TestClass]
    public class EmployeeSearchTestCase
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "SearchEmployeeSuccess", DataAccessMethod.Sequential)]
        
        public void SearchEmployeeSuccess()
        {
            EmployeeSearchClass empsearch = new EmployeeSearchClass();
            string url = TestContext.DataRow["url"].ToString();
            string employeelist = TestContext.DataRow["employeelist"].ToString();
            string search = TestContext.DataRow["search"].ToString();
            string find = TestContext.DataRow["find"].ToString();

            BasePage.seleniumInit();
            empsearch.search(url, search);
            /*string val = BasePage.driver.FindElement(LoginClass.displayname).Text;
            Assert.AreEqual(value, val);*/
            BasePage.driverClose();

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "SearchNonExistingEmployee", DataAccessMethod.Sequential)]

        public void SearchNonExistingEmployee()
        {
            EmployeeSearchClass empsearch = new EmployeeSearchClass();
            string url = TestContext.DataRow["url"].ToString();
            string employeelist = TestContext.DataRow["employeelist"].ToString();
            string search = TestContext.DataRow["search"].ToString();
            string find = TestContext.DataRow["find"].ToString();

            BasePage.seleniumInit();
            empsearch.search(url, search);
            /*string val = BasePage.driver.FindElement(LoginClass.displayname).Text;
            Assert.AreEqual(value, val);*/
            BasePage.driverClose();

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "myfile.xml", "CheckingEmployeeBenefit", DataAccessMethod.Sequential)]

        public void CheckingEmployeeBenefit()
        {
            EmployeeSearchClass empsearch = new EmployeeSearchClass();
            string url = TestContext.DataRow["url"].ToString();
            string employeelist = TestContext.DataRow["employeelist"].ToString();

            BasePage.seleniumInit();
            empsearch.benefits(url);
            /*string val = BasePage.driver.FindElement(LoginClass.displayname).Text;
            Assert.AreEqual(value, val);*/
            BasePage.driverClose();

        }



    }
}
