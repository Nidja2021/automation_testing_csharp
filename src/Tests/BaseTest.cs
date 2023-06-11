

namespace src.Tests
{
    public class BaseTest
    {
        protected IWebDriver _driver;
        protected const string BASE_URL = "https://www.saucedemo.com/";

        [SetUp]
        public void SetUp() {
            _driver = new ChromeDriver();

            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        

        [TearDown]
        public void TearDown() {
            _driver.Quit();
        }

        protected LoginPage NavigateToLoginPage() {
            _driver.Navigate().GoToUrl(BASE_URL);
            LoginPage loginPage = new LoginPage(_driver);
            return loginPage;
        }

        protected HomePage NavigateToHomePage() {
            var loginPage = NavigateToLoginPage();
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
            var homePage = loginPage.ClickLoginButton();
            return homePage;
        }

        protected ProductPage NavigateToProductPage() {
            var homePage = NavigateToHomePage();
            var productPage = homePage.ClickItemTitle();
            return productPage;
        }

        protected ShoppingCart NavigateToShoppingCartPage() {
            var homePage = NavigateToHomePage();
            return homePage.ClickShoppingCart();
        }
    }
}