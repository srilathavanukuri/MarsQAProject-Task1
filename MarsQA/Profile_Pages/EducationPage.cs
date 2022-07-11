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
    public class EducationPage : CommonDriver
    {
        public void EducationTab(IWebDriver driver)
        {
            //Identify Education tab and click on it
            IWebElement educationTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();
        
        }
        public void CreateEducation(IWebDriver driver)
        {
            //select AddNew button on click on it
            IWebElement AddnewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            AddnewButton.Click();
            //select university name
            IWebElement universityName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            universityName.Click();
            universityName.SendKeys("JNTUH");
            //select country name
            IWebElement countryname = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            SelectElement SelectCountry = new SelectElement(countryname);
            SelectCountry.SelectByValue("India");
            //Select Education Title
            IWebElement EducationTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            SelectElement SelectTitle = new SelectElement(EducationTitle);
            SelectTitle.SelectByValue("B.Tech");
            //Identify and update degree
            IWebElement DegreeUpdate = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            DegreeUpdate.Click();
            DegreeUpdate.SendKeys("Computer Science");
            //Identify and slect year of graduation
            IWebElement SelectGradYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            SelectElement selectYear = new SelectElement(SelectGradYear);
            selectYear.SelectByValue("2016");
            //Identify and Select Add Button
            IWebElement AddEducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddEducationButton.Click();
            Thread.Sleep(1000);
        }
        public void EditEducation(IWebDriver driver)
        {
            //Select EditButton
            IWebElement EditButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]"));
            EditButton.Click();
            // Identify and Edit University
            IWebElement EdituniversityName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            EdituniversityName.Clear();
            EdituniversityName.SendKeys("Industry Connect");
            //Identify and Edit country name
            IWebElement Editcountryname = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
            SelectElement SelectNewCountry = new SelectElement(Editcountryname);
            SelectNewCountry.SelectByValue("New Zealand");
            //Edit Education Title
            IWebElement EditEducationTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
            SelectElement SelectNewTitle = new SelectElement(EditEducationTitle);
            SelectNewTitle.SelectByValue("Associate");
            //Identify and update Degree
            IWebElement EditDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            EditDegree.Clear();
            EditDegree.SendKeys("Testing Engineer");
            //Idenity and update Graduation Year
            IWebElement SelectUpdateYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
            SelectElement selectEditYear = new SelectElement(SelectUpdateYear);
            selectEditYear.SelectByValue("2022");

            //Identify and Update Education Button
            IWebElement EditGradYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            EditGradYear.Click();
            Thread.Sleep(1000);
        }
        public void DeleteEducation(IWebDriver driver)
        {
            //Identify and delete Education details
            IWebElement EducationSelect = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            EducationSelect.Click();
            //Identify and click Delete Button
            IWebElement DeleteButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]"));
            DeleteButton.Click();
            Thread.Sleep(1000);
        }
        public string GetEducationDetails(IWebDriver driver)
        {
            try
            {
                driver.Navigate().Refresh();
                EducationPage EducationPageObj = new EducationPage();
                EducationPageObj.EducationTab(driver);
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10);
                IWebElement GetEducationCountry = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                return GetEducationCountry.Text;
            }
            catch (Exception)
            {
                return "No record exists";
            }
        }
        public string GetUniversityDetails(IWebDriver driver)
        {
            try
            {
                driver.Navigate().Refresh();
                EducationPage EducationPageObj = new EducationPage();
                EducationPageObj.EducationTab(driver);
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10);
                IWebElement GetUniversityValue = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
                return GetUniversityValue.Text;
            }
            catch (Exception)
            {
                return "No record exists";
            }
        }
    }
           
    
}
