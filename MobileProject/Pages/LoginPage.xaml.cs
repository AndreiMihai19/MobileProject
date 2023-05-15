using MobileProject.Classes;
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
         User user = new User(entry_password.Text);

         User.SetUsername(entry_username.Text);

        if (user.CheckUser("admin","admin") == true)
        {
            if (user.CheckIsAdmin() == true)
            {
                User.SetUserType("admin");
                await Navigation.PopAsync();
                await Navigation.PushAsync(new Pages.AdminMenu());
            }
            else
            {
                User.SetUserType("user");
                await Navigation.PopAsync();
                await Navigation.PushAsync(new MenuPage());
            }
        }
        else
        {
            await DisplayAlert("Login Problem", "Username or Password is incorrect ", "OK");
        }
    }
}

