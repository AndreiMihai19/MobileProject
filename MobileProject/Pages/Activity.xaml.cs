namespace MobileProject.Pages;

public partial class Activity : ContentPage
{
	public Activity()
	{
		InitializeComponent();
        username_show.Text = User.username;

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            currentlocaltime_show.Text = DateTime.Now.ToString("HH:mm:ss");
            return true;
        });
    }

    private void PersonalizedActivity_Clicked(object sender, EventArgs e)
    {

    }

    private async void DefaultActivity_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DefaultActivity());
    }

    private async void back_button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
        await Navigation.PushAsync(new MenuPage());

    }
}