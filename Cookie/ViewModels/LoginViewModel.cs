using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Cookie.Models;
using Cookie.Services;
using Realms;
using Realms.Sync;

namespace Cookie.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        private readonly AuthService _authService;

        private string _emailText;
        public string EmailText
        {
            get => _emailText;
            set => SetProperty(ref _emailText, value);
        }

        private string _passwordText;
        public string PasswordText
        {
            get => _passwordText;
            set => SetProperty(ref _passwordText, value);
        }

        [RelayCommand]
        private async Task LoginTry()
        {
            // for any login

            EmailText = "2@example.com";
            PasswordText = "88888888";

            try
            {
                LoginOrCreateUserAndAccount(EmailText, PasswordText);
                //App.SetLoggedInAccount(account);
                await Shell.Current.GoToAsync("//MenuPage");
            }
            catch (Exception ex)
            {
                // Log the error
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");

                // Display the error message
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }


        public async void LoginOrCreateUserAndAccount(string email, string password)
        {
            try // FIRST TRY TO LOGIN IF THERE IS AN USER
            {
                var user = await App.RealmApp.LogInAsync(Credentials.EmailPassword(email, password));
                App.loggedInAccount.SetLoggedInAccount(email);
            }
            catch (Exception ex) // IF THERE ISNT USER AND ACCOUNT
            {
                try
                {
                    // NEW REALM USER CREATED
                    await App.RealmApp.EmailPasswordAuth.RegisterUserAsync(email, password);
                    var user = await App.RealmApp.LogInAsync(Credentials.EmailPassword(email, password));
                    App.loggedInAccount.SetLoggedInAccount(email);
                }
                catch (Exception registrationEx)
                {
                    // Log detailed registration error
                    System.Diagnostics.Debug.WriteLine($"Registration failed: {registrationEx.Message}");
                    throw new InvalidOperationException("Registration failed.", registrationEx);
                }
            }
        }
    }
}