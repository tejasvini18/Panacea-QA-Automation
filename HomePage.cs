
using OpenQA.Selenium;

namespace AutomationTesting.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) {}

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://automationintesting.online/");
        }

        public bool IsTitleDisplayed()
        {
            return driver.Title.Length > 0;
        }
    }
}
