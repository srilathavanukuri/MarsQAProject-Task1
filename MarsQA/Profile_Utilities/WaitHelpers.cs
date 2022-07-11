using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA.Profile_Utilities
{
    public class WaitHelpers
    {
        // Genetick function to wait for element to be clickiable
        public static void WaitToBeClickable(IWebDriver driver, string locator, string locatorvalue, int seconds)
        {
            var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locator == "XPath")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }
            if (locator == "Id")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }
            if (locator == "CssSelectors")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }
            if (locator == "Name")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorvalue)));
            }
        }
        public static void WaitToBeVisible(IWebDriver driver, string locator, string locatorvalue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorvalue)));
            }
            if (locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorvalue)));
            }
        }
    }
}
