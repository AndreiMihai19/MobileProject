using MobileProject.Classes;
using MobileProject.Pages;

namespace MobileProject;

public partial class MenuPage : ContentPage
{
   
    [Obsolete]
    public MenuPage()
	{  
		InitializeComponent();

		username_show.Text = Credentials.username;

        

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
		{
            global_door_status.Text = Options.GetDoorStatus();
            currentlocaltime_show.Text = DateTime.Now.ToString("HH:mm:ss");
			return true;
		});
        


    }

    [Obsolete]
    private async void Back_Button(object sender, EventArgs e)
	{
		if (Credentials.GetUserType() == "user")
		{
            await Navigation.PopAsync();
            await Navigation.PushAsync(new LoginPage());
		}
		else
		{
            await Navigation.PopAsync();
            await Navigation.PushAsync(new AdminMenu());
		}

	}

	private async void Temperature_Button(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Temperature());

    }

    private async void light_button(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Light());
    }

    private async void Door_Button(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Door());
    }
}