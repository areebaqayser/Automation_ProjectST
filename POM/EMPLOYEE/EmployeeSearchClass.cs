using FinalTry.POM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM
{
    public class EmployeeSearchClass : BasePage
    {
        BasePage empsearch = new BasePage();

        #region Locators
        public static By employeeList = By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div.navbar-collapse.collapse > ul:nth-child(1) > li:nth-child(3)");
        public static By searchbar = By.Name("searchTerm");
        public static By searchbtn = By.CssSelector("body > div.container.body-content > form > input.btn.btn-default");
        public static By benefitlink = By.CssSelector("body > div.container.body-content > table > tbody > tr:nth-child(2) > td:nth-child(6) > a:nth-child(1)");

        #endregion

        #region Methods

        public void search(string url, string name)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.FindElement(employeeList).Click();
            driver.FindElement(searchbar).SendKeys(name);
            driver.FindElement(searchbtn).Submit();
              
        }
        public void benefits(string url)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.FindElement(employeeList).Click();
            driver.FindElement(benefitlink).Click();


        }
        #endregion

        /*
                IWebElement employeeList => driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div.navbar-collapse.collapse > ul:nth-child(1) > li:nth-child(3)"));
                IWebElement searchEmployee => driver.FindElement(By.Name("searchTerm"));  
                IWebElement searchbtn => driver.FindElement(By.CssSelector("body > div.container.body-content > form > input.btn.btn-default"));
        */

    }
}
