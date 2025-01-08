using FinalTry.POM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.PASSWORD
{
    public class ChangePasswordClass : BasePage
    {
        BasePage changepass = new BasePage();

        #region Locators
        public static By loginlink = By.Id("loginLink");
        public static By usernameTxt = By.Id("UserName");
        public static By passwordTxt = By.Id("Password");
        public static By loginBtn = By.ClassName("btn");
        public static By displayname = By.CssSelector("#logoutForm > ul > li:nth-child(1) > a");
        public static By changebtn = By.CssSelector("body > div.container.body-content > div > dl > dd:nth-child(2) > a");
        public static By errormsg1 = By.CssSelector("body > div.container.body-content > form > div.text-danger.validation-summary-errors > ul > li");
        public static By current = By.Id("OldPassword");
        public static By newpass = By.Id("NewPassword");
        public static By confirmpass = By.Id("ConfirmPassword");
        //  public static By req2 = By.CssSelector("#loginForm > form > div:nth-child(4) > div > span > span");

        #endregion

        #region Methods
        public void change(string url,string username, string password, string old, string confirm)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.FindElement(loginlink).Click();
            driver.FindElement(usernameTxt).SendKeys(username);
            driver.FindElement(passwordTxt).SendKeys(password);
            driver.FindElement(loginBtn).Submit();
            driver.FindElement(displayname).Click();
            driver.FindElement(changebtn).Click();
            driver.FindElement(current).SendKeys(password);
            driver.FindElement(newpass).SendKeys(old);
            driver.FindElement(confirmpass).SendKeys(confirm);
        }
        #endregion
    }
}
