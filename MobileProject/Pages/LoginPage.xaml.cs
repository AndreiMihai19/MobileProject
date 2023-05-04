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
                await Navigation.PopAsync();
                await Navigation.PushAsync(new Pages.AdminMenu());  
            }
            else
            {
                if (Credentials.username == "andrei" && cred.GetPassword() == "andrei")
                {
                    Credentials.SetUserType("user");
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new MenuPage());
                }
                else
                {
                    await DisplayAlert("Login Problem", "Username or Password is incorrect ", "OK");
            }
            }
    }
}

