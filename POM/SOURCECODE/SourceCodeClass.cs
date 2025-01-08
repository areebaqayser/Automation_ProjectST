using FinalTry.POM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.SOURCECODE
{
    public class SourceCodeClass : BasePage
    {
        BasePage src = new BasePage();

        #region Locators

        public static By sourcebtn = By.CssSelector("body > div.container.body-content > div.row > div:nth-child(3) > p:nth-child(3) > a");
        #endregion

        #region Methods

        public void sourcecode(string url, string url2)
        {
            driver.Url = url;
            driver.FindElement(sourcebtn).Click();
            driver.Navigate().GoToUrl(url2);// = url2;
        }
        #endregion

    }
}
