
namespace DiceRoller;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    private async void AboutButtonGustavo_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/Gustavo-Crnts");
    }

    private async void AboutButtonIsa_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/isaxavierz");
    }
}