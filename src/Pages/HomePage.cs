using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver) {}

        private By HomePageTitleLocator = By.ClassName("title");
        private By ItemLocator = By.ClassName("inventory_item");
        private By ItemSpecificTitleLocator = By.LinkText("Sauce Labs Backpack");
        private By ItemSpecificButtonLocator = By.XPath("//button[@id='add-to-cart-sauce-labs-backpack']");
        private By ShoppingCartLocator = By.ClassName("shopping_cart_link");
        private By ShoppingCartBadgeLocator = By.ClassName("shopping_cart_badge");

        public bool IsTitleDisplayed() {
            return IsDisplayed(HomePageTitleLocator);
        }

        public string GetHomePageTitle() {
            return GetText(HomePageTitleLocator);
        }

        public string ShowHomePageUrl() {
            return GetCurrentUrl();
        }

        public bool ItemListNotZero() {
            var element = FindElements(ItemLocator);
            return element.Count() > 0;
        }

        public void ClickItemButton() {
            ClickElement(ItemSpecificButtonLocator);
        }

        public bool IsShoppingCardBadgeDisplayed() {
            return IsDisplayed(ShoppingCartBadgeLocator);
        }

        public ProductPage ClickItemTitle() {
            ClickElement(ItemSpecificTitleLocator);
            return new ProductPage(_driver);
        }

        public ShoppingCart ClickShoppingCart() {
            ClickElement(ShoppingCartLocator);
            return new ShoppingCart(_driver);
        }
    }
}