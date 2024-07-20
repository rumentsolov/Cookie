using Cookie.Models;
using Cookie.Services;
using Cookie.Views;
namespace Cookie
{

    // Ver. 1.0.0
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>() // Ensure this matches the App class in your project
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
