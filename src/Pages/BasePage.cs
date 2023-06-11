

namespace src.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string GetTitle() {
            return _driver.Title;
        }

        protected IWebElement FindElement(By locator) {
            return _driver.FindElement(locator);
        }

        protected List<IWebElement> FindElements(By locator) {
            return _driver.FindElements(locator).ToList();
        }

        protected void EnterText(By locator, string text) {
            FindElement(locator).SendKeys(text);
        }

        protected void ClickElement(By locator) {
            FindElement(locator).Click();
        }

        protected void ClearElement(By locator) {
            FindElement(locator).Clear();
        }

        protected bool IsDisplayed(By locator) {
            return FindElement(locator).Displayed;
        }

        protected string GetText(By locator) {
            return FindElement(locator).Text;
        }

        protected string GetCurrentUrl() {
            return _driver.Url;
        }
    }
}