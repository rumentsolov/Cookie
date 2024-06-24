namespace Cookie.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
    }
    private void btn1_Cliked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HomePage));
    }
}