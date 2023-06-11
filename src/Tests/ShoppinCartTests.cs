using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Tests
{
    public class ShoppinCartTests : BaseTest
    {
        private ShoppingCart shoppingCart;

        [SetUp]
        public void Setup() {
            shoppingCart = NavigateToShoppingCartPage();
        }

        [Test]
        public void VerifyShppingCartNumberAndItemList() {
            Assert.IsTrue(shoppingCart.IsShoppingCartDisplayedCorrectly(), "Shopping cart count is not the same like item list count as expected.");
        }
    }
}