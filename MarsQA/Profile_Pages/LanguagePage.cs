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
    public class LanguagePage : CommonDriver
    {
public void LangTab(IWebDriver driver)
        {
            //Identify the language tab and click on it
            IWebElement languageTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageTab.Click();
        }
        public void LanguageAdd(IWebDriver driver)
        {
            // select Addnew button
            IWebElement addNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            //Select Add language text box
            IWebElement AddLanuageTexBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanuageTexBox.Click();
            AddLanuageTexBox.SendKeys("java");
            //Select Add level text box
            IWebElement AddlevelTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            SelectElement SelectLevel = new SelectElement(AddlevelTextBox);
            SelectLevel.SelectByValue("Basic");
            IWebElement AddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();
            Thread.Sleep(1000);
        }
            public void LanguageUpdate(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 10);
            //UpdateLanguage
            //click on edit button
            IWebElement EditOption = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            EditOption.Click();
            //Thread.Sleep(2000);
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input", 10);
            //Edit language to update
            IWebElement EditLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            EditLanguage.Clear();
            EditLanguage.SendKeys("English");
            //Thread.Sleep(2000);
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select", 10);
            //Edit Level to update
            IWebElement EditLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            SelectElement UpdatetLevel = new SelectElement(EditLevel);
            UpdatetLevel.SelectByValue("Conversational");
            //Thread.Sleep(1000);
            //Update Button Click
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 10);
            IWebElement UpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            UpdateButton.Click();
            Thread.Sleep(1000);
        }
        public void LanguageDel(IWebDriver driver)
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 20);
            //DeleteLanguage
            IWebElement SelectLanuage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            SelectLanuage.Click();
            IWebElement iconRemove = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            iconRemove.Click();
        }
        public string GetLanguageDetails(IWebDriver driver)
        {
            try
            {
                driver.Navigate().Refresh();
                LanguagePage LangPageObj = new LanguagePage();
                LangPageObj.LangTab(driver);
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 10);
                IWebElement GetLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
                return GetLanguage.Text;
            }
            catch (Exception)
            {
                return "No record exists";
            }

        }
    }
}
     
