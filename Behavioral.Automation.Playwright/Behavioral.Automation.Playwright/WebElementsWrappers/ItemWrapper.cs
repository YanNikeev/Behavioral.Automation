using Behavioral.Automation.Playwright.Context;
using Behavioral.Automation.Playwright.ElementSelectors;
using Microsoft.Playwright;

namespace Behavioral.Automation.Playwright.WebElementsWrappers;

public class ItemWrapper : WebElementWrapper
{
    public readonly ItemSelector ItemSelector;

    public ItemWrapper(WebContext webContext, ItemSelector itemSelector, string caption) :
        base(webContext, itemSelector, caption)
    {
        ItemSelector = itemSelector;
    }

    public ILocator Items => GetChildLocator(ItemSelector);

    public ILocator GetAddButton(int index)
    {
        return this.Locator.Nth(index).Locator("//button[@class='btn btn_primary btn_small btn_inventory']");
    }

    public ILocator GetRemoveButton(int index)
    {
        return this.Locator.Nth(index).Locator("//button[@class='btn btn_secondary btn_small btn_inventory']");
    }
}