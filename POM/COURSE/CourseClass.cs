using FinalTry.POM.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalTry.POM.COURSE
{
    public class CourseClass : BasePage
    {
        BasePage course = new BasePage();

        #region Locators
        
        public static By displayname = By.CssSelector("#page-header > yt-page-header-renderer > yt-page-header-view-model > div > div.page-header-view-model-wiz__page-header-headline > div > yt-dynamic-text-view-model > h1 > span");
        public static By ytbtn = By.XPath("/html/body/div[2]/div[2]/div[2]/p[2]/a[2]");
        public static By udemybtn = By.XPath("/html/body/div[2]/div[2]/div[2]/p[2]/a[1]");


        #endregion

        #region Methods
        public void youtube(string url)
        {
            driver.Url = url;
            
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // Locate the element using the CSS selector
            IWebElement link = driver.FindElement(By.CssSelector("body > div.container.body-content > div.row > div:nth-child(2) > p:nth-child(3) > a:nth-child(2)"));

            // Click the link to open it
            link.Click();
            //driver.FindElement(ytbtn).Click();
            //driver.Url = url2;
            
        }
        public void udemy(string url, string url2)
        {
            driver.Url = url;

            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.FindElement(udemybtn).Click();
            driver.Url = url2;

        }

        #endregion
    }
}
