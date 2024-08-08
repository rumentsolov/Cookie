using Cookie.Views;

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
            Routing.RegisterRoute(nameof(ContactUsPage), typeof(ContactUsPage));
            Routing.RegisterRoute(nameof(AccountPage), typeof(AccountPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
            // Subscribe to the Navigating event
            //this.Navigating += OnNavigating;
        }

/*        private void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {
            // Check if the new item is the Basket tab
            if (e.Target.Location.OriginalString.Contains("//Basket"))
            {
                // Find the BasketPage in the navigation stack
                var basketPage = e.Target.Location.OriginalString.Split('/').Last();
                if (basketPage == "BasketPage")
                {
                    
                    //var basket = FindByName<BasketPage>("BasketPage");
                    //basket?.RefreshPage(); // Call the refresh method in BasketPage
                }
            }
        }*/
    }
}
