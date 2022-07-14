using MarsQA.Profile_Pages;
using MarsQA.Profile_Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinition
{
    [Binding]
    public class EEducationStepDefinitions : CommonDriver
    {
        [After]
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }
        [Given(@"Login to Mars Portal page successfully")]
        public void GivenLoginToMarsPortalPageSuccessfully()
        {

            //OPen Chrome Browser
            driver = new ChromeDriver();
            //Login Steps of the portal
            LoginPage LogingpageObj = new LoginPage();
            LogingpageObj.Loginsteps(driver);
        }

        [When(@"I click on Education tab")]
        public void WhenIClickOnEducationTab()
        {
            EducationPage EducationPageObj = new EducationPage();
            EducationPageObj.EducationTab(driver);
        }

        [When(@"I add Education")]
        public void WhenIAddEducation()
        {
            EducationPage EducationPageObj = new EducationPage();
            EducationPageObj.CreateEducation(driver);
        }

        [Then(@"I should be able to view edit Education record")]
        public void ThenIShouldBeAbleToViewEditEducationRecord()
        {
            EducationPage EducationPageObj = new EducationPage();
            string GetEducationCountry = EducationPageObj.GetEducationDetails(driver);
            Assert.That(GetEducationCountry == "India", "University country did not Match");
            string GetUniversityValue = EducationPageObj.GetUniversityDetails(driver);
            Assert.That(GetUniversityValue == "JNTUH", "University Name did not Match");
        }

        [When(@"I update Education")]
        public void WhenIUpdateEducation()
        {
            EducationPage EducationPageObj = new EducationPage();
            EducationPageObj.EditEducation(driver);
        }

        [Then(@"I should be able to Update Education record successfully")]
        public void ThenIShouldBeAbleToUpdateEducationRecordSuccessfully()
        {
            EducationPage EducationPageObj = new EducationPage();
            string GetEducationCountry = EducationPageObj.GetEducationDetails(driver);
            Assert.That(GetEducationCountry == "New Zealand", "University country did not Match");
            string GetUniversityValue = EducationPageObj.GetUniversityDetails(driver);
            Assert.That(GetUniversityValue == "Industry Connect", "University Name did not Match");
        }

        [When(@"I deleted Education")]
        public void WhenIDeletedEducation()
        {
            EducationPage EducationPageObj = new EducationPage();
            EducationPageObj.DeleteEducation(driver);
        }

        [Then(@"I should be able to delete record successfuly")]
        public void ThenIShouldBeAbleToDeleteRecordSuccessfuly()
        {
            EducationPage EducationPageObj = new EducationPage();
            string GetEducationCountry = EducationPageObj.GetEducationDetails(driver);
            Assert.That(GetEducationCountry != "New Zealand", "University country did not delete successfully");
            string GetUniversityValue = EducationPageObj.GetUniversityDetails(driver);
            Assert.That(GetUniversityValue != "Industry Connect", "University Name did not delete successfully");
        }
    }
}
