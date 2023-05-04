using MobileProject.Classes;

namespace MobileProject.Pages;

public partial class Light : ContentPage
{
	public Light()
	{
		InitializeComponent();
        username_show.Text = Credentials.username;

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            currentlocaltime_show.Text = DateTime.Now.ToString("HH:mm:ss");
            return true;
        });
    }
}