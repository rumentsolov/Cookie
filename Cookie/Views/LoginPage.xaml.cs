using Cookie.Services;

namespace Cookie.Views;

public partial class LoginPage : ContentPage
{
	private readonly AuthService _authService;

	public LoginPage(AuthService authService)
	{
		InitializeComponent();
		_authService = authService;
	}

    private async void ButtonLogin_Clicked(object sender, EventArgs e)
    {
		_authService.LogIn();
		await Shell.Current.GoToAsync($"//MenuPage");
    }
}