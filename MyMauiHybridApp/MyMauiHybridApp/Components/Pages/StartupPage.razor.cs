﻿using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyMauiHybridApp.MauiPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiHybridApp.Components.Pages
{
    public partial class StartupPage
    {
        [Inject] NavigationManager _navigationManager { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            // Initialize custom configuration
            await Task.Delay(500);

            var isLoggedIn = true;
            if (isLoggedIn)
            {
                //_navigationManager.NavigateTo("/home", replace: true);
                App.Current!.MainPage = new HomeMauiPage();
            }
            else
            {
                _navigationManager.NavigateTo("/login", replace: true);
            }
        }
    }
}
