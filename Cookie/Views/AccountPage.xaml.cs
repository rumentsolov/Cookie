using Cookie.Models;
using Cookie.Services;
using Cookie.ViewModels;


namespace Cookie.Views
{
    public partial class AccountPage : ContentPage
    {
        //private readonly AuthService _authService;
        public AccountPage()
        {

            InitializeComponent();
            BindingContext = new AccountViewModel();
        }

/*        private async void OnEditAccountClicked(object sender, EventArgs e)
        {
            // Navigate to an edit account page or display an edit form
            await DisplayAlert("Edit Account", "This feature is not implemented yet.", "OK");
        }

        private void btnLogoutCliked(object sender, EventArgs e)
        {
            _authService.LogOut();
            Shell.Current.GoToAsync("//LoginPage");
        }*/
    }
}
