using MarsQA.Profile_Pages;
using MarsQA.Profile_Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinition
{
    [Binding]
    public class DSkillsStepDefinitions : CommonDriver
    {
        [After]
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }
        [Given(@"I login to Mars Portal page")]
        public void GivenILoginToMarsPortalPage()
        {

            //OPen Chrome Browser
            driver = new ChromeDriver();
            //Login Steps of the portal
            LoginPage LogingpageObj = new LoginPage();
            LogingpageObj.Loginsteps(driver);
        }

        [When(@"I click on Skills tab")]
        public void WhenIClickOnSkillsTab()
        {
            SkillsPage SkillsPageObj = new SkillsPage();
            SkillsPageObj.SkillTab(driver); ;
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
    }
}
