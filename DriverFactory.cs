
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTesting.Utilities
{
    public class DriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return new ChromeDriver(options);
        }
    }
}
