using Cookie.Models;
using Microsoft.Maui.Controls;

namespace Cookie.Views
{
    public partial class AccountPage : ContentPage
    {
        public Account Account { get; set; }

        public AccountPage()
        {
            InitializeComponent();
            Account = new Account
            {
                Username = "JohnDoe",
                Email = "john.doe@example.com",
                PhoneNumber = "123-456-7890",
                Address = "123 Main St, Springfield, USA"
                // Initialize other account details as needed
            };
            BindingContext = Account;
        }

        private async void OnEditAccountClicked(object sender, EventArgs e)
        {
            // Navigate to an edit account page or display an edit form
            await DisplayAlert("Edit Account", "This feature is not implemented yet.", "OK");
        }
    }
}
