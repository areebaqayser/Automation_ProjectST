using FinalTry.POM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.REGISTER
{
    public class RegisterClass : BasePage
    {
        BasePage reg = new BasePage();

        #region Locators
        public static By registerlink = By.Id("registerLink");
        public static By Txtusername = By.Id("UserName");
        public static By Txtpassword = By.Id("Password");
        public static By Txtconfirm = By.Id("ConfirmPassword");
        public static By Txtemail = By.Id("Email");
        public static By registerbtn = By.CssSelector("body > div.container.body-content > form > div:nth-child(9) > div > input");
        public static By displayname = By.CssSelector("body > div.container.body-content > form > div.text-danger.validation-summary-errors > ul > li");

        #endregion

        #region Methods
        public void register(string url, string register, string username, string password, string confirm, string email)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.FindElement(registerlink).Click();
            driver.FindElement(Txtusername).SendKeys(username);
            driver.FindElement(Txtpassword).SendKeys(password);
            driver.FindElement(Txtconfirm).SendKeys(confirm);
            driver.FindElement(Txtemail).SendKeys(email);
            driver.FindElement(registerbtn).Submit();
            //   
        }
        #endregion
    }
}
