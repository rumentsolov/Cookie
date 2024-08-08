using Cookie.Models;
using MongoDB.Bson;
using Realms;

namespace Cookie
{
    public partial class App : Application
    {
        public static Realms.Sync.App RealmApp { get; private set; }
        public static LoggedInAccount loggedInAccount;
        public App()
        {
            InitializeComponent();
            loggedInAccount = LoggedInAccount.Instance;
            RealmApp = Realms.Sync.App.Create(AppConfig.RealmAppId);
            if (AppInfo.RequestedTheme == AppTheme.Dark)
            {
                App.Current.UserAppTheme = AppTheme.Dark; //It works also with  Application.Current.UserAppTheme = AppTheme
            }
            else
            {
                App.Current.UserAppTheme = AppTheme.Light;
            }
            MainPage = new AppShell();
        }

        private void SetAppTheme()
        {

        }
    }
}