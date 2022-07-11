// See https://aka.ms/new-console-template for more information
using MarsQA.Profile_Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
driver.Navigate().GoToUrl("http://localhost:5000/home");
Thread.Sleep(1000);
// Identify signIn button and click
IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1] / div / a"));
signInButton.Click();

// Identify Email address text box and enter valid email address
IWebElement Emailaddress = driver.FindElement(By.XPath("/ html / body / div[2] / div / div / div[1] / div / div[1] / input"));
Emailaddress.SendKeys("srilathareddy203@gmail.com");

// Identify Password text box and enter valid password
IWebElement Password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
Password.SendKeys("viyaan@2019");

// Identify Login Button and click
IWebElement Loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
Loginbutton.Click();
Console.WriteLine("Mars Home page launched successfully");

//Update Profile Information
// Click on profile button

WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[1]/div/a[2]", 5);
//Thread.Sleep(1000);
// Click on profile tab
IWebElement profileTab = driver.FindElement(By.XPath("//div/section[1]/div/a[2]"));
profileTab.Click();

//DropDown
IWebElement dropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
dropDown.Click();
WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]", 10);
//Thread.Sleep(1000);
// select on FirstName Text Box
IWebElement firstNameTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
firstNameTextBox.Clear();
firstNameTextBox.SendKeys("Srilatha");


// Select on LastName Text Box
IWebElement LastNameTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
LastNameTextBox.Clear();
LastNameTextBox.SendKeys("Vanukuri");

// click on Save Button
IWebElement SaveButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
SaveButton.Click();
//WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span", 10);
Thread.Sleep(1000);
// select Availability from dropdown
IWebElement availabilityOption = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
//Edit Availability to update
IWebElement EditAvail = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
EditAvail.Click();

IWebElement availabilitySelect = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
SelectElement selectAvail = new SelectElement(availabilitySelect);
selectAvail.SelectByValue("1");// Select value from Inspect option example Fulltime is 1

// Select Hours from dropdown
IWebElement HoursOption = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
//Edit Hours to Update
IWebElement EditHours = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
EditHours.Click();
IWebElement HoursSelect = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
SelectElement selectHours = new SelectElement(HoursSelect);
selectHours.SelectByValue("1");// Select value from Inspect option

//Select Earn Target
IWebElement EarnTarget = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
//Edit EarnTarget to update
IWebElement EditEarn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
EditEarn.Click();
IWebElement EarnSelect = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
SelectElement SelectEarn = new SelectElement(EarnSelect);
SelectEarn.SelectByValue("2");
Console.WriteLine("Mars Profile updated successfully");
//Thread.Sleep(1000);
WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10);

//Identify the language tab and click on it
IWebElement languageTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
languageTab.Click();
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
Console.WriteLine("language updated successfully");

//Thread.Sleep(2000);
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
WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 10);
//Update Button Click
IWebElement UpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
UpdateButton.Click();
Console.WriteLine("Language edited successfully");
Thread.Sleep(1000);
//DeleteLanguage
IWebElement SelectLanuage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
SelectLanuage.Click();
IWebElement iconRemove = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
iconRemove.Click();

//AddSkills
//Identify the Skills tab and click on it
IWebElement skillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
skillTab.Click();
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
Thread.Sleep(1000);
//Edit Skill and Levell and click
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
//Delete Skill
IWebElement Deleteskill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
Deleteskill.Click();
Thread.Sleep(1000);
IWebElement Deleteskillbutton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
Deleteskillbutton.Click();
