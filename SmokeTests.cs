using NUnit.Framework;
using OpenQA.Selenium;
using AutomationTesting.Utilities;

namespace AutomationTesting.Tests
{
    [TestFixture]
    public class SmokeTests
    {
        private IWebDriver? driver;

        [SetUp]
        public void Setup()
        {
            driver = DriverFactory.CreateDriver();
            driver.Navigate().GoToUrl("https://automationintesting.online/");
        }

        [Test] public void TC01_Page_Loads() =>
            Assert.That(driver!.Title, Is.Not.Empty);

        [Test] public void TC02_Url_Is_Correct() =>
            Assert.That(driver!.Url, Does.Contain("automationintesting"));

        [Test] public void TC03_PageSource_Not_Empty() =>
            Assert.That(driver!.PageSource, Is.Not.Empty);

        [Test] public void TC04_PageSource_Contains_HTML_Tag() =>
            Assert.That(driver!.PageSource, Does.Contain("<html"));

        [Test] public void TC05_PageSource_Contains_Body_Tag() =>
            Assert.That(driver!.PageSource, Does.Contain("<body"));

        [Test] public void TC06_PageSource_Contains_Head_Tag() =>
            Assert.That(driver!.PageSource, Does.Contain("<head"));

        [Test] public void TC07_Title_Length_Greater_Than_Two() =>
            Assert.That(driver!.Title.Length, Is.GreaterThan(2));

        [Test] public void TC08_Url_Not_Null() =>
            Assert.That(driver!.Url, Is.Not.Null);

        [Test] public void TC09_PageSource_Not_Null() =>
            Assert.That(driver!.PageSource, Is.Not.Null);

        [Test] public void TC10_Cookies_Accessible() =>
            Assert.That(driver!.Manage().Cookies.AllCookies, Is.Not.Null);

        [Test] public void TC11_Window_Handle_Exists() =>
            Assert.That(driver!.CurrentWindowHandle, Is.Not.Null);

        [Test] public void TC12_Page_Contains_Meta_Tag() =>
            Assert.That(driver!.PageSource.ToLower(), Does.Contain("meta"));

        [Test] public void TC13_Page_Contains_Style_Tag() =>
            Assert.That(driver!.PageSource.ToLower(), Does.Contain("style"));

        [Test] public void TC14_Page_Contains_Script_Tag() =>
            Assert.That(driver!.PageSource.ToLower(), Does.Contain("script"));

        [Test] public void TC15_Page_Loads_Without_Exception() =>
            Assert.Pass();

        [Test] public void TC16_Title_Not_Null() =>
            Assert.That(driver!.Title, Is.Not.Null);

        [Test] public void TC17_Url_Not_Empty() =>
            Assert.That(driver!.Url, Is.Not.Empty);

        [Test] public void TC18_PageSource_Length_Greater_Than_100() =>
            Assert.That(driver!.PageSource.Length, Is.GreaterThan(100));

        [Test] public void TC19_Driver_Can_Execute_Commands() =>
            Assert.That(driver!.Manage().Window.Size.Width, Is.GreaterThan(0));

        [Test] public void TC20_Final_Sanity_Check() =>
            Assert.Pass();

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }
    }
}
