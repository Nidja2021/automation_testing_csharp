using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Pages
{
    public class ProductPage : BasePage
    {
        public ProductPage(IWebDriver driver) : base(driver) {}

        private By ItemTitleLocator = By.ClassName("inventory_details_name");
        private By ItemPriceLocator = By.ClassName("inventory_details_price");
        private By ItemButtonLocator = By.XPath("//button[normalize-space()='Add to cart']");
        private By ShoppingCartLocator = By.ClassName("shopping_cart_link");
        private By ShoppingCartBadgeLocator = By.ClassName("shopping_cart_badge");

        public bool IsItemTitleDisplayed() {
            return IsDisplayed(ItemTitleLocator);
        }

        public bool IsItemPriceDisplayed() {
            return IsDisplayed(ItemPriceLocator);
        }

        public string GetItemTitle() {
            return GetText(ItemTitleLocator);
        }

        public void ClickItemButton() {
            ClickElement(ItemButtonLocator);
        }

        public bool IsShoppingCardBadgeDisplayed() {
            return IsDisplayed(ShoppingCartBadgeLocator);
        }

    }
}