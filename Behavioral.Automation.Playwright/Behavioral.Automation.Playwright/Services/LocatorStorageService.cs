using System;
using Behavioral.Automation.Playwright.Pages;
using Behavioral.Automation.Playwright.Services.ElementSelectors;
using Behavioral.Automation.Playwright.Utils;
using JetBrains.Annotations;

namespace Behavioral.Automation.Playwright.Services;

[UsedImplicitly]
public class LocatorStorageService
{
    //TODO: Impl factory
    public T Get<T>(string elementName)
    {
        //TODO:impl search service, check type is exist
        var mainPage = typeof(MainPage);
        var page = Activator.CreateInstance(mainPage);

        var element = (T)mainPage.GetField(elementName.ToCamelCase())?.GetValue(page)!;
        if (element is null) throw new Exception($"'{elementName}' selectors not found.");
        return element;
    }
}