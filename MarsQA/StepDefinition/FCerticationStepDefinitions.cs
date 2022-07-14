using MarsQA.Profile_Pages;
using MarsQA.Profile_Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinition
{
    [Binding]
    public class FCerticationStepDefinitions : CommonDriver
    {
        [After]
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }
        [Given(@"Logged into MARS portal successfully to access CERT tab")]
        public void GivenLoggedIntoMARSPortalSuccessfullyToAccessCERTTab()
        {
            //OPen Chrome Browser
            driver = new ChromeDriver();
            //Login Steps of the portal
            LoginPage LogingpageObj = new LoginPage();
            LogingpageObj.Loginsteps(driver);
        }

        [When(@"I click on Certification tab")]
        public void WhenIClickOnCertificationTab()
        {
            CertificationPage CertificationPageObj = new CertificationPage();
            CertificationPageObj.CertificationTab(driver);
        }

        [When(@"I can create new certification record")]
        public void WhenICanCreateNewCertificationRecord()
        {
            CertificationPage CertificationPageObj = new CertificationPage();
            CertificationPageObj.CreateCertification(driver);
        }

        [Then(@"I should be able to view the created Certifcations record")]
        public void ThenIShouldBeAbleToViewTheCreatedCertifcationsRecord()
        {
            CertificationPage CertificationPageObj = new CertificationPage();
            string GetCertDetails = CertificationPageObj.GetCertName(driver);
            Assert.That(GetCertDetails == "BTech Graduation", "Certification Name did not Match");
        }

        [When(@"I can edit the existing certification record")]
        public void WhenICanEditTheExistingCertificationRecord()
        {
            CertificationPage CertificationPageObj = new CertificationPage();
            CertificationPageObj.EditCertification(driver);
        }

        [Then(@"I should be able to update certification record sucessfully")]
        public void ThenIShouldBeAbleToUpdateCertificationRecordSucessfully()
        {
            CertificationPage CertificationPageObj = new CertificationPage();
            string GetCertDetails = CertificationPageObj.GetCertName(driver);
            Assert.That(GetCertDetails == "Test Analyst", "Certification Name did not Match");
        }

        [When(@"I can delete the existing certification record")]
        public void WhenICanDeleteTheExistingCertificationRecord()
        {
            CertificationPage CertificationPageObj = new CertificationPage();
            CertificationPageObj.DeleteCertification(driver);
        }

        [Then(@"I should be able to delete record record sucessfully")]
        public void ThenIShouldBeAbleToDeleteRecordRecordSucessfully()
        {
            CertificationPage CertificationPageObj = new CertificationPage();
            string GetCertDetails = CertificationPageObj.GetCertName(driver);
            Assert.That(GetCertDetails != "Test Analyst", "Certification still exist and not deleted successfully");
        }
    }
}
