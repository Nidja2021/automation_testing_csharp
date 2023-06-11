using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Pages
{
    public class LoginPage : BasePage
    {
        private By UsernameLocator = By.Id("user-name");
        private By PasswordLocator = By.Id("password");
        private By LoginButtonLocator = By.Id("login-button");
        private By ErrorMessageLocator = By.CssSelector("#login_button_container > div > form > div.error-message-container.error > h3");
        private By ErrorMessageFieldsRequiredLocator = By.XPath("//h3[normalize-space()='Epic sadface: Username is required']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        
        public string GetLoginPageTitle() {
            return GetTitle();
        }

        public void EnterUsername(string text) {
            EnterText(UsernameLocator, text);
        }

        public void EnterPassword(string text) {
           EnterText(PasswordLocator, text);
        }

        public HomePage ClickLoginButton() {
            ClickElement(LoginButtonLocator);
            return new HomePage(_driver);
        }

        public bool IsErrorDisplayed() {
            return IsDisplayed(ErrorMessageLocator);
        }

        public string ErrorMessageRequiredFields() {
            return GetText(ErrorMessageFieldsRequiredLocator);
        }
    }
}