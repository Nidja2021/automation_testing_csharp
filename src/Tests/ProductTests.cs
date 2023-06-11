using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Tests
{
    public class ProductTests : BaseTest
    {
        private ProductPage productPage;

        [SetUp]
        public void Setup() {
            productPage = NavigateToProductPage();
        }

        [Test]
        public void VerifyProductPageTitle() {
            var isDisplayed = productPage.IsItemTitleDisplayed();
            Assert.IsTrue(isDisplayed, "Product title is not displayed as expected.");
        }

        [Test]
        public void VerifyProductPagePrice() {
            var isDisplayed = productPage.IsItemPriceDisplayed();
            Assert.IsTrue(isDisplayed, "Product price is not displayed as expected.");
        }

        [Test]
        public void VerifyShoppingCartBadgeNotDisplayed() {
            Assert.False(productPage.IsShoppingCardBadgeDisplayed(), "Shopping cart badge is displayed as not expected.");
        }

        [Test]
        public void VerifyShoppingCartBadge() {
            productPage.ClickItemButton();
            var isDisplayed = productPage.IsShoppingCardBadgeDisplayed();

            Assert.True(isDisplayed, "Shopping cart badge is not displayed as expected.");
        }

        
    }
}