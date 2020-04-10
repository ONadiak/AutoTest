using AutomationpracticeTest.Services;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationpracticeTest
{
    public class BaseTest
    {
        protected IWebDriver WebDriver;

        [OneTimeSetUp]
        protected void DoBeforeAllTests()
        {
            WebDriver = new ChromeDriver();
        }
        
        [OneTimeTearDown]
        protected void DoAfterEach()
        {
            WebDriver.Quit();
        }

        [SetUp]
        protected void DoBeforeEach()
        {
            WebDriver.Manage().Cookies.DeleteAllCookies();
            WebDriver.Manage().Window.Maximize();
            WebDriver.Navigate().GoToUrl(UserNameForTest.Link);
            WaitUntil.ShouldLocate(WebDriver, UserNameForTest.Link);
        }

    }
}