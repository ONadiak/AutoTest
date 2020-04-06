using OpenQA.Selenium;

namespace AutomationpracticeTest.PageObjects
{
    public class MainPagePageObject
    {
        private IWebDriver _webDriver;
        
        private readonly By _imgToBuy = By.XPath("//a[@title = 'Faded Short Sleeve T-shirts']");

        public MainPagePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }


        public TShirtPageObject ClickOnImage()
        {
            _webDriver.FindElement(_imgToBuy).Click();
            return new TShirtPageObject(_webDriver);
        }
    }
}