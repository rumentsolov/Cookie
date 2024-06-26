using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace Cookie
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
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