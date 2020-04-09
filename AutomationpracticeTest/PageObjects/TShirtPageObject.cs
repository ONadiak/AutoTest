using System.Threading;
using AutomationpracticeTest.Services;
using OpenQA.Selenium;

namespace AutomationpracticeTest.PageObjects
{
    public class TShirtPageObject
    {
        private IWebDriver _webDriver; 
        private readonly By _addToCartButton = By.XPath("//span[text() = 'Add to cart']"); 
        private readonly By _proceedButton = By.XPath("//a[@class = 'btn btn-default button button-medium']");


        public TShirtPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public OrderPageObject AddTshirtToCart()
        {
            WaitUntil.WaitElement(_webDriver, _addToCartButton );
            _webDriver.FindElement(_addToCartButton).Click();
            WaitUntil.WaitElement(_webDriver, _proceedButton );
            _webDriver.FindElement(_proceedButton).Click();
            return new OrderPageObject(_webDriver);

        }
    }
}