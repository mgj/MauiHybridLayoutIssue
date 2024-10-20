using Microsoft.Maui.Controls;

namespace MyMauiHybridApp.MauiPages;

public partial class HomeMauiPage : Shell
{
    public List<TabBarItem> TabBarItems { get; set; } = [];

    public HomeMauiPage()
	{
        InitializeComponent();

        Task.Run(Init);
    }

    private async Task Init()
    {
        // More initialization of the app, navigation, features etc.
        await Task.Delay(500);

        // Remove the loading ShellContent
        if (this.Items.Contains(homeMauiPageLoadingShellContent))
        {
            this.Items.Remove(homeMauiPageLoadingShellContent);
        }

        TabBarItems = [new TabBarItem()];
        var tabBar = new TabBar();
        foreach (var item in TabBarItems)
        {
            var shellContent = new ShellContent
            {
                Title = "MyTitle",
                ContentTemplate = new DataTemplate(() => new BlazorMauiPage())
            };
            // Load tabbar items
            var tab = new Tab
            {
                Title = "TestTitle",
                Icon = "dotnet_bot.svg",
                Items = { shellContent }
            };
            tabBar.Items.Add(tab);
        }
        this.Items.Add(tabBar);
    }
}