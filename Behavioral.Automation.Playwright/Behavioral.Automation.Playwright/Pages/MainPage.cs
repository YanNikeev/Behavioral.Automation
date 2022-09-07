using Behavioral.Automation.Configs;
using Behavioral.Automation.Playwright.Configs;
using Behavioral.Automation.Playwright.ElementSelectors;

namespace Behavioral.Automation.Playwright.Pages;

class MainPage : ISelectorStorage
{
    private static readonly string Id = ConfigManager.GetConfig<Config>().SearchAttribute;
    
    //Login
    public ElementSelector Username = new() { IdSelector = "username"};
    public ElementSelector Password = new() { IdSelector = "password"};
    public ElementSelector LoginButton = new() { IdSelector = "login-button"};

    //Common elements
    public ElementSelector PageTitle = new() { Selector = "//span[@class='title']" };
    public ElementSelector InventoryList = new() { Selector = "//div[@class='inventory_list']/*" };

    //Add items to the cart
    public ElementSelector AddBackpackToCart = new() { IdSelector = "add-to-cart-sauce-labs-backpack" };
    public ElementSelector AddBikeLightToCart = new() { IdSelector = "add-to-cart-sauce-labs-bike-light" };
    public ElementSelector AddBoltTShirtToCart = new() { IdSelector = "add-to-cart-sauce-labs-bolt-t-shirt" };

    //ShoppingCart
    public ElementSelector ShoppingCart = new() { Selector = "//a[@class='shopping_cart_link']" };
    public ElementSelector ShoppingCartBadge = new() { Selector = "//span[@class='shopping_cart_badge']"};
    public ElementSelector CartQuantityLabel = new() { Selector = "//div[@class='cart_quantity_label']" };
    public ElementSelector CartDescriptionLabel = new() { Selector = "//div[@class='cart_desc_label']" };
    public ElementSelector ContinueShoppingButton = new() { IdSelector = "continue-shopping" };
    public ElementSelector CheckoutButton = new() { IdSelector = "checkout" };
    public ElementSelector InventoryItemName = new() { Selector = "//div[@class='inventory_item_name']" };

    //Remove items from the cart
    public ElementSelector RemoveBackpackFromCart = new() { IdSelector = "remove-sauce-labs-backpack" };

    //Checkout information
    public ElementSelector ContinueButton = new() { IdSelector = "continue" };
    public ElementSelector CancelButton = new() { IdSelector = "cancel" };
    public ElementSelector FirstNameInput = new() { IdSelector = "firstName" };
    public ElementSelector LastNameInput = new() { IdSelector = "lastName" };
    public ElementSelector PostalCodeInput = new() { IdSelector = "postalCode" };

    //Checkout overview
    public ElementSelector FinishButton = new() { IdSelector = "finish" };

    //Checkout complete
    public ElementSelector CompleteHeader = new() { Selector = "//h2[@class='complete-header']" };
    public ElementSelector BackToProductsButton = new() { IdSelector = "back-to-products" };
}