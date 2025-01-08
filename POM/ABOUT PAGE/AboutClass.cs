using FinalTry.POM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.ABOUT_PAGE
{
    public class AboutClass :  BasePage
    {
        BasePage aboutpage = new BasePage();

    #region Locators

    public static By aboutlink = By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div.navbar-collapse.collapse > ul > li:nth-child(2) > a");
   // public static By value = By.CssSelector("body > div.container.body-content > h2");
    #endregion

        #region Methods

        public void About(string url)
    {
        driver.Url = url;
        driver.Manage().Window.Maximize();
        driver.FindElement(aboutlink).Click();
    }
    #endregion

}
}
