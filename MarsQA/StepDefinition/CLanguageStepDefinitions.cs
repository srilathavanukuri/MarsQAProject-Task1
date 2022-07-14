using MarsQA.Profile_Pages;
using MarsQA.Profile_Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinition
{
    [Binding]
    public class CLanguageStepDefinitions : CommonDriver
    {
        [After]
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }
        [Given(@"I logged into to Mars Portal")]
        public void GivenILoggedIntoToMarsPortal()
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
            LangPageObj.LangTab(driver);
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
            LangPageObj.LangTab(driver);
            string GetLanguage = LangPageObj.GetLanguageDetails(driver);
            Assert.That(GetLanguage != "English", "Language not deleted successfully");
        }
    }
}
