using FinalTry.POM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM
{
    public class LoginClass : BasePage
    {
        BasePage loginpage = new BasePage();

        #region Locators
        public static By loginlink = By.Id("loginLink");
        public static By usernameTxt = By.Id("UserName");
        public static By passwordTxt = By.Id("Password");
        public static By loginBtn = By.ClassName("btn");
        public static By displayname = By.CssSelector("#logoutForm > ul > li:nth-child(1)");
        public static By errormsg = By.CssSelector("#loginForm > form > div.validation-summary-errors.text-danger > ul > li");
        public static By chk = By.Id("RememberMe");
        public static By req1 = By.CssSelector("#loginForm > form > div:nth-child(2) > div > span > span");
      //  public static By req2 = By.CssSelector("#loginForm > form > div:nth-child(4) > div > span > span");

        #endregion


        #region Method

        /*IWebElement loginlink => driver.FindElement(By.Id("loginLink"));
        IWebElement Txtusername => driver.FindElement(By.Id("UserName"));
        IWebElement Txtpassword => driver.FindElement(By.Id("Password"));
        IWebElement loginbtn => driver.FindElement(By.ClassName("btn"));
        IWebElement registerlink => driver.FindElement(By.Id("registerLink"));
        IWebElement password2 => driver.FindElement(By.Name("ConfirmPassword"));
        IWebElement TxtEmail => driver.FindElement(By.Id("Email"));
        IWebElement registerbtn => driver.FindElement(By.CssSelector("body > div.container.body-content > form > div:nth-child(9) > div > input"));
*/


        public void login(string url, string username, string password)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.FindElement(loginlink).Click();
            driver.FindElement(usernameTxt).SendKeys(username);
            driver.FindElement(passwordTxt).SendKeys(password);
            driver.FindElement(loginBtn).Submit();
            //   
        }

        public void checkbox(string url, string username, string password)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.FindElement(loginlink).Click();
            driver.FindElement(usernameTxt).SendKeys(username);
            driver.FindElement(passwordTxt).SendKeys(password);
            driver.FindElement(chk).Click();
            driver.FindElement(loginBtn).Submit();
            //   
        }
        #endregion

        /*public void register(string username, string password, string confirm, string email)
        {
            registerlink.Click();
            Txtusername.SendKeys(username);
            Txtpassword.SendKeys(password);
            password2.SendKeys(confirm);
            TxtEmail.SendKeys(email);
            registerbtn.Submit();

        }*/
        /* public void Quit()
         {
             driver.Close();
         }*/
    }
}
