using Cookie.Models;
using Cookie.Services;
using Cookie.Views;
using CommunityToolkit.Maui;
using Cookie.ViewModels;

namespace Cookie
{

    // Ver. 2.0.1
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            // Initialize the .NET MAUI Community Toolkit by adding the below line of code
            .UseMauiCommunityToolkit()
            // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

            builder.Services.AddTransient<AuthService>();
            builder.Services.AddSingleton<LoggedInAccount>();

            // Register view models
            builder.Services.AddSingleton<LoginViewModel>();

            // Register views
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<MenuPage>();
            builder.Services.AddSingleton<MenuPage>();
            builder.Services.AddSingleton<DishDetailPage>();
            builder.Services.AddSingleton<ContactUsPage>();
            builder.Services.AddSingleton<LoadingPage>();
            builder.Services.AddSingleton<AccountPage>();
            builder.Services.AddSingleton<HomePage>();

            builder.Services.AddSingleton<BasketPage>();


            return builder.Build();
        }
    }
}
