namespace MobileProject;


public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
	

    private async void Login_Clicked(object sender, EventArgs e)
    {
            Credentials cred = new Credentials(entry_username.Text, entry_password.Text);
            if (cred.GetUsername() == "admin" && cred.GetPassword() == "admin")
            {
                await Navigation.PushAsync(new MenuPage());
            }
            else
            {
                await DisplayAlert("Login Problem", "Username or Password is incorrect ", "OK");
            }
    }
}

