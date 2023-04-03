namespace MobileProject;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}

	private async void Back_Button(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
}