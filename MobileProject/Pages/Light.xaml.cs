using MobileProject.Classes;

namespace MobileProject.Pages;

public partial class Light : ContentPage
{
	public Light()
	{
		InitializeComponent();
        username_show.Text = User.username;

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            currentlocaltime_show.Text = DateTime.Now.ToString("HH:mm:ss");
            return true;
        });
        light_value_test.Text = Options.GetLightValue().ToString();
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Options.SetLightValue((int)e.NewValue);
        light_value_test.Text = Options.GetLightValue().ToString();
    }

    private async void back_button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
        await Navigation.PushAsync(new MenuPage());
    }
}