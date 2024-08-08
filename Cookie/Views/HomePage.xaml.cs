namespace Cookie.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
