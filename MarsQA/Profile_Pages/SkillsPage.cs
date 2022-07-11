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
    public class SkillsPage : CommonDriver
    {
        public void SkillTab(IWebDriver driver)
        {
            //Identify the Skills tab and click on it
            IWebElement skillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();
        }
        public void AddSkills(IWebDriver driver)
        {
            //SelectAddnew button
            IWebElement AddnewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddnewButton.Click();
            //Add Skills and click on it
            IWebElement addSkills = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkills.Click();
            addSkills.SendKeys("Manual testing");
            //Add Level and click on it
            IWebElement addLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SelectElement SelectSkill = new SelectElement(addLevel);
            SelectSkill.SelectByValue("Beginner");
            //Add button and click on it
            IWebElement addbuttonSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addbuttonSkill.Click();
            Thread.Sleep(2000);
        }
        public void SkillUpdate(IWebDriver driver)
        {
            //Edit Skill and Level and click
            IWebElement EditSkillbutton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
            EditSkillbutton.Click();
            //Idintify skill Update
            IWebElement SkillUpdate = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            SkillUpdate.Clear();
            SkillUpdate.SendKeys("Automation testing");
            //Update Level and click on it
            IWebElement UpdateLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            SelectElement Selectupdateskill = new SelectElement(UpdateLevel);
            Selectupdateskill.SelectByValue("Intermediate");
            //Click on updte Skill
            IWebElement updateskill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateskill.Click();
            Thread.Sleep(2000);
        }
        public void SkillDelete(IWebDriver driver)
        {
            //Delete Skill
            IWebElement Deleteskill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            Deleteskill.Click();
            Thread.Sleep(1000);
            IWebElement Deleteskillbutton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            Deleteskillbutton.Click();
            Thread.Sleep(1000);
        }
        public string GetSkillDetails(IWebDriver driver)
        {
            try
            {
                driver.Navigate().Refresh();
                SkillsPage SkillsPageObj = new SkillsPage();
                SkillsPageObj.SkillTab(driver);
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10);
                IWebElement GetSkillValue = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                return GetSkillValue.Text;
            }
            catch (Exception)
            {
                return " No record exists";
            }
        }
       
    }
}
