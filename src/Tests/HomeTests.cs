using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Tests
{
    public class HomeTests : BaseTest
    {
        private HomePage homePage;

        [SetUp]
        public new void SetUp() {
            homePage = NavigateToHomePage();

            // homePage = new HomePage(_driver);
        }

        [Test]
        public void VerifyHomePageTitle() {
            var actual = homePage.GetHomePageTitle();
            Assert.AreEqual("Products", actual, "Home page title is not as expected.");
        }

        [Test]
        public void VerifyNumberOfItems() {
            Assert.True(homePage.ItemListNotZero(), "Item counts is 0");
        }

        [Test]
        public void VerifyItemTitleOnClickItemTitle() {
            var productPage = homePage.ClickItemTitle();

            var expected = "Sauce Labs Backpack";
            var actual = productPage.GetItemTitle();

            Assert.AreEqual(expected, actual, "Item title is not the same as expected.");
        }

        [Test]
        public void VerifyItemTitleOnClickItemTitleNegative() {
            var productPage = homePage.ClickItemTitle();

            var expected = "Sauce Labs Backpacke";
            var actual = productPage.GetItemTitle();

            Assert.AreNotEqual(expected, actual, "Item title is the same as not expected.");
        }

        [Test]
        public void VerifyShoppingCartBadgeNotDisplayed() {
            Assert.False(homePage.IsShoppingCardBadgeDisplayed(), "Shopping cart badge is displayed as not expected.");
        }

        [Test]
        public void VerifyShoppingCartBadge() {
            homePage.ClickItemButton();
            var isDisplayed = homePage.IsShoppingCardBadgeDisplayed();

            Assert.True(isDisplayed, "Shopping cart badge is not displayed as expected.");
        }

        [Test]
        public void GoToShoppingCartPage() {
            var shoppingCart = homePage.ClickShoppingCart();

            var expected = "Your Cart";
            var actual = shoppingCart.GetShoppingCartTitle();
            Assert.AreEqual(expected, actual, "Shopping cart title is not as expected.");
        }

    }
}