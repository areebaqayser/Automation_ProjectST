using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTry.POM.Core
{
    public class BasePage
    {
        public static IWebDriver driver;

        public static void seleniumInit()
        {
            var mydriver = new ChromeDriver();

            driver = mydriver;

        }
        public static void driverClose()
        {
            driver.Close();
        }
    }
}
