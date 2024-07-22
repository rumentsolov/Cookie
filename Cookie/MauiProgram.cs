using Cookie.Models;
using Cookie.Services;
using Cookie.Views;
using CommunityToolkit.Maui;

namespace Cookie
{

    // Ver. 1.0.0
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
            builder.Services.AddTransient<LoadingPage>();
            builder.Services.AddTransient<MenuPage>();
            builder.Services.AddTransient<BasketPage>();
            builder.Services.AddTransient<AccountPage>();
            builder.Services.AddTransient<LoginPage>();
            //public static List<Dish> BasketItems;


            return builder.Build();
        }
    }
}
