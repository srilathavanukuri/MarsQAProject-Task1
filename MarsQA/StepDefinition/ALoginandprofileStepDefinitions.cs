using MarsQA.Profile_Pages;
using MarsQA.Profile_Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinition
{
    [Binding]
    public class ALoginandprofileStepDefinitions : CommonDriver
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
    }
}
