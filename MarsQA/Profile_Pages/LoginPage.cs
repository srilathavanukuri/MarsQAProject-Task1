using MarsQA.Profile_Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Profile_Pages
{
    public class LoginPage
    {
        public void Loginsteps(IWebDriver driver)
        {

            //IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/home");

            Thread.Sleep(1000);
            // Identify signIn button and click
            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1] / div / a"));
            signInButton.Click();

            // Identify Email address text box and enter valid email address
            IWebElement Emailaddress = driver.FindElement(By.XPath("/ html / body / div[2] / div / div / div[1] / div / div[1] / input"));
            Emailaddress.SendKeys("srilathareddy203@gmail.com");

            // Identify Password text box and enter valid password
            IWebElement Password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            Password.SendKeys("viyaan@2019");

            // Identify Login Button and click
            IWebElement Loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            Loginbutton.Click();
            Thread.Sleep(2000);

        }
        public string GetUserName(IWebDriver driver)
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/div[1]/div[2]/div/span", 10);
            IWebElement GetuserDetails = driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span"));
            return GetuserDetails.Text;
            
        }

          
            

           
        
    }
}
