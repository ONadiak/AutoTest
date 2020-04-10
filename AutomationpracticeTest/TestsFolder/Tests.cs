using AutomationpracticeTest.PageObjects;
using AutomationpracticeTest.Services;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationpracticeTest
{
    [TestFixture]
    public class Tests : BaseTest 
    {
        
        [Test]
        public void Test1()
        {
            var mainMenu = new MainPagePageObject(WebDriver);
            var orderMenu = new OrderPageObject(WebDriver);
            mainMenu
                .ClickOnImage()
                .AddTshirtToCart()
                .CheckIsOrderRemovedByPrice();
            string actualPrice = orderMenu.CheckIsOrderRemovedByPrice();
            Assert.AreEqual(UserNameForTest.ExpectedPrice, actualPrice, "Buy is wrong or wasn't completed");
        }
        [Test]
        public void Test2()
        {
            var mainMenu = new MainPagePageObject(WebDriver);
            var orderMenu = new OrderPageObject(WebDriver);
            mainMenu
                .ClickOnImage()
                .AddTshirtToCart()
                .RemoveOrder()
                .CheckIsOrderRemoved();
            string actualResult = orderMenu.CheckIsOrderRemoved();
            Assert.AreEqual(UserNameForTest.ExpectedResult, actualResult, "Remowing is wrong or wasn't completed");
        }
        
    }
}