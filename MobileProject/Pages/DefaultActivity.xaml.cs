using MobileProject.Classes;

namespace MobileProject.Pages;
public partial class DefaultActivity : ContentPage
{
	public DefaultActivity()
	{
		InitializeComponent();
        username_show.Text = User.username;

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            currentlocaltime_show.Text = DateTime.Now.ToString("HH:mm:ss");
            return true;
        });
    }

    private void manual_Clicked(object sender, EventArgs e)
    {

        Options.SetActivity("ce plm e butonu asta");
    }

    private void manual_Clicked_1(object sender, EventArgs e)
    {
        Options.SetActivity("manual");

    }

    private async void job_Clicked(object sender, EventArgs e)
    {
        Options.SetActivity("job");
        await Navigation.PopAsync();
        await Navigation.PushAsync(new MenuPage());
    }

    private async void weekend_Clicked(object sender, EventArgs e)
    {
        Options.SetActivity("weekend");
        await Navigation.PopAsync();
        await Navigation.PushAsync(new MenuPage());
    }

    private async void holiday_Clicked(object sender, EventArgs e)
    {
        Options.SetActivity("holiday");
        await Navigation.PopAsync();
        await Navigation.PushAsync(new MenuPage());
    }

    private async void back_button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
        await Navigation.PushAsync(new Activity());
    }
}