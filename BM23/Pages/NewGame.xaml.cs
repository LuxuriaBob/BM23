namespace BM23.Pages;

public partial class NewGame : ContentPage
{
	public NewGame()
	{
		InitializeComponent();

        var countryList = new List<string>();
        countryList.Add("Turkey");
        countryList.Add("United States of America");
        countryList.Add("Germany");
        countryList.Add("England");
        countryList.Add("France");
        countryList.Add("Japan");
        countryList.Add("South Korea");

        Picker countryPicker = new Picker { Title = "Select a country" };
            countryPicker.ItemsSource = countryList;
	}
    void PreviousBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new MainMenu());
    }

    void NextBtn_Clicked(System.Object sender, System.EventArgs e)
    {

    }
}