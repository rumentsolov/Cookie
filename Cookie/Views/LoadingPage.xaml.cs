using Cookie.Services;


namespace Cookie.Views;

public partial class LoadingPage : ContentPage
{
	private readonly AuthService _authService;
	public LoadingPage(AuthService authService)
	{
		InitializeComponent();
		_authService = authService;
	}


    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (await _authService.IsAuthenticatedAsync())
        {
            // User is logged in
           await Shell.Current.GoToAsync($"//{nameof(HomePage)}"); // $"//{nameof(HomePage)}" means no backup button, if I want backup button goes like $"{nameof(HomePage)}"
        }
        else
        {
            // User is not logged in
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

    }
}