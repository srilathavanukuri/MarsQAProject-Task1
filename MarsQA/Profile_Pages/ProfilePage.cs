using MarsQA.Profile_Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Profile_Pages
{
    public class ProfilePage : CommonDriver
    {
        public void UpdateProfile(IWebDriver driver)
        {
            //Update Profile Information
            // Click on profile button

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[1]/div/a[2]", 5);
            // Click on profile tab
            IWebElement profileTab = driver.FindElement(By.XPath("//div/section[1]/div/a[2]"));
            profileTab.Click();

            //DropDown
            IWebElement dropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            dropDown.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]", 10);
            //Thread.Sleep(1000);
            // select on FirstName Text Box
            IWebElement firstNameTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
            firstNameTextBox.Clear();
            firstNameTextBox.SendKeys("Srilatha");


            // Select on LastName Text Box
            IWebElement LastNameTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            LastNameTextBox.Clear();
            LastNameTextBox.SendKeys("Vanukuri");

            // click on Save Button
            IWebElement SaveButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            SaveButton.Click();
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span", 10);
            Thread.Sleep(1000);
            // select Availability from dropdown
            IWebElement availabilityOption = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            //Edit Availability to update
            IWebElement EditAvail = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            EditAvail.Click();
        }
        public void ProfileDetailsUpdate(IWebDriver driver)
        {
            IWebElement availabilitySelect = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            SelectElement selectAvail = new SelectElement(availabilitySelect);
            selectAvail.SelectByValue("1");// Select value from Inspect option example Fulltime is 1

            // Select Hours from dropdown
            IWebElement HoursOption = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            //Edit Hours to Update
            IWebElement EditHours = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            EditHours.Click();
            IWebElement HoursSelect = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
            SelectElement selectHours = new SelectElement(HoursSelect);
            selectHours.SelectByValue("1");// Select value from Inspect option

            //Select Earn Target
            IWebElement EarnTarget = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
            //Edit EarnTarget to update
            IWebElement EditEarn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            EditEarn.Click();
            IWebElement EarnSelect = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
            SelectElement SelectEarn = new SelectElement(EarnSelect);
            SelectEarn.SelectByValue("2");
        }
        public string GetProfileValue(IWebDriver driver)
        {
            WaitHelpers.WaitToBeVisible(driver, "Xpath", "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]", 10);
            IWebElement GetProfileDetails = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
                return GetProfileDetails.Text;
        }
    }
}
    
