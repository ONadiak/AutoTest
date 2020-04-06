using System;
using System.Security.AccessControl;
using System.Threading;
using AutomationpracticeTest.PageObjects;
using AutomationpracticeTest.Services;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationpracticeTest
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver _webDriver;
        
        
        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(UserNameForTest.Link);
        }
        
        
        
        [Test]
        public void Test1()
        {
          var mainMenu = new MainPagePageObject(_webDriver);
          var orderMenu = new OrderPageObject(_webDriver);
          mainMenu
              .ClickOnImage()
              .AddToCart()
              .Check();
          string actualPrice = orderMenu.Check();
          Assert.AreEqual(UserNameForTest.ExpectedPrice, actualPrice, "Buy is wrong or wasn't completed");
        }

        [Test]
        public void Test2()
        {
            var mainMenu = new MainPagePageObject(_webDriver);
            var orderMenu = new OrderPageObject(_webDriver);
            mainMenu
                .ClickOnImage()
                .AddToCart()
                .RemoveOrder()
                .CheckIsOrderRemoved();
            string actualResult = orderMenu.CheckIsOrderRemoved();
            Assert.AreEqual(UserNameForTest.ExpectedResult, actualResult, "Remowing is wrong or wasn't completed");


        }



        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}