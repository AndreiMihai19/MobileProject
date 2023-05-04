using MobileProject.Classes;

namespace MobileProject.Pages;

public partial class Door : ContentPage
{
	public Door()
	{
        InitializeComponent();
        username_show.Text = Credentials.username;

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            currentlocaltime_show.Text = DateTime.Now.ToString("HH:mm:ss");
            return true;
        });
        door_status.Text = Options.GetDoorStatus();
        global_door_status.Text = Options.GetDoorStatus();
    }

    private void open_door_Button(object sender, EventArgs e)
    {
        Options.Door_Open();
        door_status.Text = Options.GetDoorStatus();
        global_door_status.Text = Options.GetDoorStatus();

    }

    private void close_door_Button(object sender, EventArgs e)
    {
        Options.Door_Close();
        door_status.Text = Options.GetDoorStatus();
        global_door_status.Text = Options.GetDoorStatus();
    }

    private async void back_button2(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
        await Navigation.PushAsync(new MenuPage());
    }
}