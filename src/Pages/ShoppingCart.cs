using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Pages
{
    public class ShoppingCart : BasePage
    {
        public ShoppingCart(IWebDriver driver) : base(driver) {}

        private By ShoppingCartTitleLocator = By.ClassName("title");
        private By ShoppingCartItemLocator = By.ClassName("cart_item");
        private By ShoppingCartBadgeLocator = By.ClassName("shopping_cart_badge");
        private By ItemButtonRemoveLocator = By.XPath("//button[normalize-space()='Remove']");

        public string GetShoppingCartTitle() {
            return GetText(ShoppingCartTitleLocator);
        }

        public bool IsShoppingCartDisplayedCorrectly() {
            var item_list = FindElements(ShoppingCartItemLocator);
            var cart_badge = FindElement(ShoppingCartBadgeLocator);

            return item_list.Count().ToString() == cart_badge.ToString();
        }

        public void ClickItemRemoveButton() {
            ClickElement(ItemButtonRemoveLocator);
        }
    }
}