using System;
using System.Linq;
using System.Threading.Tasks;
using Behavioral.Automation.Playwright.WebElementsWrappers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Behavioral.Automation.Playwright.Bindings;

[Binding]
public class ItemBinding
{
    [Given(@"user adds the ""(.*)"" item from ""(.*)"" to the cart")]
    [When(@"user adds the ""(.*)"" item from ""(.*)"" to the cart")]
    public async Task AddItemToCart(string itemName, ItemWrapper element)
    {
        var allTextContents = await element.Locator.AllTextContentsAsync();
        var index = allTextContents.ToList().FindIndex(s => s.StartsWith(itemName, StringComparison.InvariantCultureIgnoreCase));
        if (index < 0)
        {
            Assert.Fail($"No element with text '{itemName}' found in '{element}' collection.");
        }
        await element.GetAddButton(index).ClickAsync();
    }

    [Given(@"user removes the ""(.*)"" item from ""(.*)"" from the cart")]
    [When(@"user removes the ""(.*)"" item from ""(.*)"" from the cart")]
    public async Task RemoveItemFromCart(string itemName, ItemWrapper element)
    {
        var allTextContents = await element.Locator.AllTextContentsAsync();
        var index = allTextContents.ToList().FindIndex(s => s.StartsWith(itemName, StringComparison.InvariantCultureIgnoreCase));
        if (index < 0)
        {
            Assert.Fail($"No element with text '{itemName}' found in '{element}' collection.");
        }
        await element.GetRemoveButton(index).ClickAsync();
    }
}