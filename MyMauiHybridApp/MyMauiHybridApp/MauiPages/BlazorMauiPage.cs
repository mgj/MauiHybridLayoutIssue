using Microsoft.AspNetCore.Components.WebView.Maui;
using MyMauiHybridApp.Components;
using MyMauiHybridApp.Components.Pages;
using static MudBlazor.CategoryTypes;

namespace MyMauiHybridApp.MauiPages;

public class BlazorMauiPage : ContentPage
{
	public BlazorMauiPage()
	{
        var blazorWebView = new BlazorWebView();
        blazorWebView.HostPage = "wwwroot/index.html";
        blazorWebView.RootComponents.Add(new RootComponent
        {
            Selector = "#app",
            ComponentType = typeof(Routes),
        });
        blazorWebView.StartPath = "/home";

        Content = blazorWebView;
    }
}