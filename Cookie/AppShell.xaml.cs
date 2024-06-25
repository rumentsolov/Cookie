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
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(GiftCardsPage), typeof(GiftCardsPage));
            Routing.RegisterRoute(nameof(PartnerWithUsPage), typeof(PartnerWithUsPage));
        }
    }
}
