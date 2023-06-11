using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Tests
{
    public class LoginTests : BaseTest
    {
        
        [Test]
        public void LoginGetTitleTest() {
            var loginPage = NavigateToLoginPage();

            Assert.AreEqual("Swag Labs", loginPage.GetTitle(), "Title is not as expected.");
        }

        [Test]
        public void LoginCorrectInputTest() {
            var loginPage = NavigateToLoginPage();

            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
            var homePage = loginPage.ClickLoginButton();

            Assert.True(homePage.IsTitleDisplayed());
        }

        [Test]
        public void LoginIncorrectUsernameTest() {
            var loginPage = NavigateToLoginPage();

            loginPage.EnterUsername("standard_userr");
            loginPage.EnterPassword("secret_sauce");
            loginPage.ClickLoginButton();

            Assert.True(loginPage.IsErrorDisplayed());
        }

        [Test]
        public void LoginIncorrectPasswordTest() {
            var loginPage = NavigateToLoginPage();

            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_saucee");
            loginPage.ClickLoginButton();

            Assert.True(loginPage.IsErrorDisplayed());
        }

        [Test]
        public void LoginFieldRequiredTest() {
            var loginPage = NavigateToLoginPage();

            loginPage.ClickLoginButton();
            var errorMessage = "Epic sadface: Username is required";

            Assert.AreEqual(errorMessage, loginPage.ErrorMessageRequiredFields(), "Error message is not as expected.");
        }
    }
}