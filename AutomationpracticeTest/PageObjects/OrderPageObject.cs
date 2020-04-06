using System.Threading;
using AutomationpracticeTest.Services;
using OpenQA.Selenium;

namespace AutomationpracticeTest.PageObjects
{
    public class OrderPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _price = By.Id("total_product_price_1_1_0");
        private readonly By _removeButton = By.XPath("//a[@class = 'cart_quantity_delete']");
        private readonly By _checkIsOrderRemoved = By.XPath("//p[@class = 'alert alert-warning']");
        

        public OrderPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string Check()
        { 
            string price = _webDriver.FindElement(_price).Text;
            return price;
        }

        public OrderPageObject RemoveOrder()
        {
            WaitUntil.WaitElement(_webDriver, _removeButton);
            _webDriver.FindElement(_removeButton).Click();
            return this;
        }

        public string CheckIsOrderRemoved()
        {
          WaitUntil.WaitElement(_webDriver, _checkIsOrderRemoved);
            string chekIsOrderOrderRemoved = _webDriver.FindElement(_checkIsOrderRemoved).Text;
            return chekIsOrderOrderRemoved;
        }
        
    }
}