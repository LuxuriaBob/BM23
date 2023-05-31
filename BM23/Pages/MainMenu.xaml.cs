using Microsoft.Maui.Controls;

namespace BM23.Pages;

public partial class MainMenu : ContentPage
{
	public MainMenu()
	{
		InitializeComponent();
	}

    void NewGameBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new NewGame());
    }

    void LoadGameBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Console.WriteLine("loadgame");
    }

    void SettingsBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Settings());
    }

    async void ExitBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        bool answer = await DisplayAlert("Exiting the game", "Are you sure you want to exit?", "Yes", "No");
        if (answer == true)
        {
            Application.Current.Quit();
        }
    }
}
