namespace MobileProject;


public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	

    private async void Login_Clicked(object sender, EventArgs e)
    {
            Credentials cred = new Credentials(entry_username.Text, entry_password.Text);
            if (cred.GetUsername() == "andreimihai19" && cred.GetPassword() == "123456")
            {
                await DisplayAlert("Congratulations", "Congratulations!", "OK");
            }
            else
            {
                await DisplayAlert("Congratulations", "Task Failed Succesfully", "OK");
            }
    }
}

