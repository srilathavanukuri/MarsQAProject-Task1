using MarsQA.Profile_Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Profile_Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        LoginPage LogingpageObj = new LoginPage();

        public void LoginActions()
        {
            //opem chrome browser
            driver = new ChromeDriver();

            //Login page object initialization and definition
            LogingpageObj.Loginsteps(driver);
        }
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
