using MobileProject.Classes;

namespace MobileProject.Pages;

public partial class Temperature : ContentPage
{
    [Obsolete]
    public Temperature()
	{
		InitializeComponent();

        username_show.Text = User.username;

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            currentlocaltime_show.Text = DateTime.Now.ToString("HH:mm:ss");
            return true;
        });
    }

    private void Plus_Button(object sender, EventArgs e)
    {
        if (Options.GetTemperature() < 25) 
        {
            Options.IncreaseTemperature();
            temperature_value.Text = Options.GetTemperature().ToString();
        }
        

    }

    private void Minus_Button(object sender, EventArgs e)
    {
        if (Options.GetTemperature() > 16)
        {
            Options.DecreaseTemperature();
            temperature_value.Text = Options.GetTemperature().ToString();
        }
    }

    private async void Back_Button(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
        await Navigation.PushAsync(new MenuPage());
    }
}