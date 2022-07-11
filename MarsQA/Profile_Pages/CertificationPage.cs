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
    public class CertificationPage : CommonDriver
    {
        public void CertificationTab(IWebDriver driver)
        {
            //Identify and clik Certification Tab
            IWebElement CertTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            CertTab.Click();
        }
        public void CreateCertification(IWebDriver driver)
        {
            //Identify and Click Add New Button
            IWebElement addNewCert = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewCert.Click();
            //Identify and Certification name
            IWebElement addCertName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            addCertName.Click();
            addCertName.SendKeys("BTech Graduation");
            //Identify and Certification issued
            IWebElement addCertGivenby = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            addCertGivenby.Click();
            addCertGivenby.SendKeys("JNTUH");
            //Identify and Certification Year
            IWebElement addCertYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            SelectElement selectCertYear = new SelectElement(addCertYear);
            selectCertYear.SelectByValue("2016");
            //Identify and Click Add Button
            IWebElement AddCertButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            AddCertButton.Click();
        }
        public void EditCertification(IWebDriver driver)
        {
            //Select Certification name to update
            IWebElement LastCertName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            LastCertName.Click();
            //Identify and Click Edit Button
            IWebElement EditCertButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]"));
            EditCertButton.Click();
            //Identify and Update Certificate Name
            IWebElement EditCertName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
            EditCertName.Clear();
            EditCertName.SendKeys("Test Analyst");
            //Identify and update certification issued
            IWebElement EditCertIssued = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));
            EditCertIssued.Clear();
            EditCertIssued.SendKeys("Industry Connect");
            //Identify and Update certification year
            IWebElement EditCertYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select"));
            SelectElement selectEditYear = new SelectElement(EditCertYear);
            selectEditYear.SelectByValue("2022");
            //Identify and CLick Update Button
            IWebElement UpdateNewCert = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            UpdateNewCert.Click();
        }
        public void DeleteCertification(IWebDriver driver)
        {
            //Select Certification name to update
            IWebElement LastCertName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            LastCertName.Click();
            //Identify and Delete Button
            IWebElement DelCert = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]"));
            DelCert.Click();
            
        }
        public string GetCertName(IWebDriver driver)
        {
            try
            {
                driver.Navigate().Refresh();
                CertificationPage CertificationPageObj = new CertificationPage();
                CertificationPageObj.CertificationTab(driver);
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 10);
                IWebElement GetCertDetails = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
                return GetCertDetails.Text;
            }
            catch (Exception)
            {
                return "No record exists";
            }

        }
    }
}
