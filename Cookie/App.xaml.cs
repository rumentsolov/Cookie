using Microsoft.Maui.Controls;

namespace Cookie
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
