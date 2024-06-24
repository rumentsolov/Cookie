using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Cookie
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set the main page to AppShell
            MainPage = new AppShell();
        }
    }
}
