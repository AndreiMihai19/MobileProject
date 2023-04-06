namespace MobileProject;


public partial class LoginPage : ContentPage
{   
    public string user_type; 
	public LoginPage()
	{
		InitializeComponent();

    }

    [Obsolete]
    private async void Login_Clicked(object sender, EventArgs e)
    {
            Credentials cred = new Credentials(entry_password.Text);

            Credentials.SetUsername(entry_username.Text);

            if (Credentials.username == "admin" && cred.GetPassword() == "admin")
            {
                Credentials.SetUserType("admin");
                await Navigation.PushAsync(new Pages.AdminMenu());
            }
            else
            {
            //  await DisplayAlert("Login Problem", "Username or Password is incorrect ", "OK");
                Credentials.SetUserType("user");
                await Navigation.PushAsync(new MenuPage());
            }
    }
}

