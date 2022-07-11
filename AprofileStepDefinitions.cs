using MarsQA.Profile_Pages;
using MarsQA.Profile_Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA
{
    [Binding]
    public class AprofileStepDefinitions : CommonDriver
    {
        [Given(@"Launch MarsQA Portl and Sign in Successfully")]
        public void GivenLaunchMarsQAPortlAndSignInSuccessfully()
        {
            //OPen Chrome Browser
            driver = new ChromeDriver();
            //Login Steps of the portal
            LoginPage LogingpageObj = new LoginPage();
            LogingpageObj.Loginsteps(driver);
        }

        [Then(@"I should be able to login successfully\.")]
        public void ThenIShouldBeAbleToLoginSuccessfully_()
        {
            LoginPage LogingpageObj = new LoginPage();
            string GetuserDetails = LogingpageObj.GetUserName(driver);
            Assert.That(GetuserDetails == "Hi Srilatha", "User not Matched");
        }

        [Given(@"Logged into Mars portal successfully")]
        public void GivenLoggedIntoMarsPortalSuccessfully()
        {
            //OPen Chrome Browser
            driver = new ChromeDriver();
            //Login Steps of the portal
            LoginPage LogingpageObj = new LoginPage();
            LogingpageObj.Loginsteps(driver);
        }

        [When(@"Update First Name,Last Name in the profile")]
        public void WhenUpdateFirstNameLastNameInTheProfile()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.UpdateProfile(driver);
        }

        [When(@"click Availability, Hours, Earn Target")]
        public void WhenClickAvailabilityHoursEarnTarget()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.ProfileDetailsUpdate(driver);
        }

        [Then(@"Profiles details updated successfully")]
        public void ThenProfilesDetailsUpdatedSuccessfully()
        {
            ProfilePage profilePageObj = new ProfilePage();
            string GetProfileDetails = profilePageObj.GetProfileValue(driver);
            Assert.That(GetProfileDetails == "Srilatha Vanukuri", "Profile Not matched");
        }

        [Given(@"I login to profile page")]
        public void GivenILoginToProfilePage()
        {
            //OPen Chrome Browser
            driver = new ChromeDriver();
            //Login Steps of the portal
            LoginPage LogingpageObj = new LoginPage();
            LogingpageObj.Loginsteps(driver);
        }

        [When(@"I click on language tab")]
        public void WhenIClickOnLanguageTab()
        {
            LanguagePage LangPageObj = new LanguagePage();
            LangPageObj.LangTab(driver);
        }

        [When(@"I add language")]
        public void WhenIAddLanguage()
        {
            LanguagePage LangPageObj = new LanguagePage();
            LangPageObj.LanguageAdd(driver);
        }

        [Then(@"I should be able to view edited language record")]
        public void ThenIShouldBeAbleToViewEditedLanguageRecord()
        {
            LanguagePage LangPageObj = new LanguagePage();
            //string GetLanguageDetails = LangPageObj.GetLanguage(driver);
            string GetLanguage = LangPageObj.GetLanguageDetails(driver);
            Assert.That(GetLanguage == "java", "Language did not Match");
           


        }

        [When(@"I update language")]
        public void WhenIUpdateLanguage()
        {
            LanguagePage LangPageObj = new LanguagePage();
            LangPageObj.LanguageUpdate(driver);
        }

        [Then(@"I should be able to update language sucessfully")]
        public void ThenIShouldBeAbleToUpdateLanguageSucessfully()
        {
            LanguagePage LangPageObj = new LanguagePage();
            string GetLanguage = LangPageObj.GetLanguageDetails(driver);
            Assert.That(GetLanguage == "English", "Language did not Match");
        }

        [When(@"I delete the language")]
        public void WhenIDeleteTheLanguage()
        {
            LanguagePage LangPageObj = new LanguagePage();
            LangPageObj.LanguageDel(driver);
        }

        [Then(@"I should be able to delete record successfully")]
        public void ThenIShouldBeAbleToDeleteRecordSuccessfully()
        {
            LanguagePage LangPageObj = new LanguagePage();
            string GetLanguage = LangPageObj.GetLanguageDetails(driver);
            Assert.That(GetLanguage != "English", "Language not deleted successfully");
        }

        [When(@"I click on Skills tab")]
        public void WhenIClickOnSkillsTab()
        {
            SkillsPage SkillsPageObj = new SkillsPage();
            SkillsPageObj.SkillTab(driver);
        }

        [When(@"I add Skills")]
        public void WhenIAddSkills()
        {
            SkillsPage SkillsPageObj = new SkillsPage();
            SkillsPageObj.AddSkills(driver);
        }

        [Then(@"I should be able to view edit skills record")]
        public void ThenIShouldBeAbleToViewEditSkillsRecord()
        {
            SkillsPage SkillsPageObj = new SkillsPage();
            
            string GetSkillValue = SkillsPageObj.GetSkillDetails(driver);
            Assert.That(GetSkillValue == "Manual testing", "Skill did not Match");
        }

        [When(@"I update Skils")]
        public void WhenIUpdateSkils()
        {
            SkillsPage SkillsPageObj = new SkillsPage();
            SkillsPageObj.SkillUpdate(driver);
        }

        [Then(@"I should be able to update Skills record sucessflly")]
        public void ThenIShouldBeAbleToUpdateSkillsRecordSucessflly()
        {
            SkillsPage SkillsPageObj = new SkillsPage();

            string GetSkillValue = SkillsPageObj.GetSkillDetails(driver);
            Assert.That(GetSkillValue == "Automation testing", "Skill did not Match");
        }

        [When(@"I delete  the sklils")]
        public void WhenIDeleteTheSklils()
        {
            SkillsPage SkillsPageObj = new SkillsPage();
            SkillsPageObj.SkillDelete(driver);
        }

        [Then(@"I should be able to  delete Skill record  successfully")]
        public void ThenIShouldBeAbleToDeleteSkillRecordSuccessfully()
        {
            SkillsPage SkillsPageObj = new SkillsPage();

            string GetSkillValue = SkillsPageObj.GetSkillDetails(driver);
            Assert.That(GetSkillValue != "Automation testing", "Skill not deleted Successfully");
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

        [When(@"I click on Certificatios tab")]
        public void WhenIClickOnCertificatiosTab()
        {
            CertificationPage certificationPageObj = new CertificationPage();
            certificationPageObj.CertificationTab(driver);
        }

        [Then(@"I should be able to view edited Certifcations record")]
        public void ThenIShouldBeAbleToViewEditedCertifcationsRecord()
        {
            throw new PendingStepException();
        }

        [When(@"I click on Certification tab")]
        public void WhenIClickOnCertificationTab()
        {
            throw new PendingStepException();
        }

        [When(@"I add Certification")]
        public void WhenIAddCertification()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to update certification record sucessfully")]
        public void ThenIShouldBeAbleToUpdateCertificationRecordSucessfully()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to delete record record sucessfully")]
        public void ThenIShouldBeAbleToDeleteRecordRecordSucessfully()
        {
            throw new PendingStepException();
        }
    }
}
