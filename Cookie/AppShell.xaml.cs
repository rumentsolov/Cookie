using Cookie.Views;
using Microsoft.Maui.Controls;

namespace Cookie
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(MenuPage), typeof(MenuPage));
            Routing.RegisterRoute(nameof(BasketPage), typeof(BasketPage));
            Routing.RegisterRoute(nameof(DishDetailPage), typeof(DishDetailPage));
        }
    }
}
