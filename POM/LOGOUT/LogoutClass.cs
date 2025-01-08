using FinalTry.POM.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.LOGOUT
{
   
    public class LogoutClass : BasePage
    {
       BasePage logoutpage = new BasePage();

        #region Locators
        public static By loginlink = By.Id("loginLink");
        public static By Txtusername = By.Name("UserName");
        public static By Txtpassword = By.Name("Password");
        public static By loginbtn = By.Id("loginIn");
        public static By logoutlink = By.CssSelector("#logoutForm > ul > li:nth-child(2) > a");
        
        #endregion

        #region Methods
        public void logout(string url, string username, string password)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.FindElement(loginlink).Click();
            driver.FindElement(Txtusername).SendKeys(username);
            driver.FindElement(Txtpassword).SendKeys(password);
            driver.FindElement(loginbtn).Submit();
            driver.FindElement(logoutlink).Click();
        }


       #endregion
    }
}
