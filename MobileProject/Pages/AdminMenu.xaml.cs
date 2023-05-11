namespace MobileProject.Pages;

public partial class AdminMenu : ContentPage
{
    [Obsolete]
    public AdminMenu()
	{
		InitializeComponent();

        username_show.Text = Credentials.username;

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            currentlocaltime_show.Text = DateTime.Now.ToString("HH:mm:ss");
            return true;
        });
    } 

    [Obsolete]
    private async void AdminMenu_Button(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());
        
    }

    private async void CreateUser_Button(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateAccountPage());
    }

    private async void showusers_button1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Baza());
    }
}