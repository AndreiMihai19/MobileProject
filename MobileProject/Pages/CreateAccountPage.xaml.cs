namespace MobileProject.Pages;

public partial class CreateAccountPage : ContentPage
{
    [Obsolete]
    public CreateAccountPage()
	{
		InitializeComponent();

        username_show.Text = Credentials.username;

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            currentlocaltime_show.Text = DateTime.Now.ToString("HH:mm:ss");
            return true;

        });
    }

    private async void Back_Button(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdminMenu());
    }

    private async void CreateUser_Button(object sender, EventArgs e)
    {
        if (entry_username.Text.CompareTo("") == 0 || entry_password.Text.CompareTo("") == 0)
        {
            await DisplayAlert("Alert", "Segmentation fault", "Back");
        }
        else
        {
            await DisplayAlert("", $"{entry_username.Text} was created!", "Back");
        }
    }
}