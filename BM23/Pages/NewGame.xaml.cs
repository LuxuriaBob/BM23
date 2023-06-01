using Microsoft.Maui;

namespace BM23.Pages;

public partial class NewGame : ContentPage
{
    string selectedFirstName, selectedSurname, selectedCountry, selectedCurrency, selectedGender;

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

        NextBtn.IsEnabled = false;

        Picker countryPicker = new Picker { Title = "Select a country" };
            countryPicker.ItemsSource = countryList;
	}

    void PreviousBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new MainMenu());
    }

    void NextBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new TeamSelect());
    }

    void FirstName_Entry_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        selectedFirstName = FirstName_Entry.Text;
    }

    void Surname_Entry_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        selectedSurname = Surname_Entry.Text;
    }

    void countryPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
        if (countryPicker.SelectedIndex != -1)
        {
            selectedCountry = countryPicker.SelectedItem.ToString();
            // Do something with the selected country (store it, process it, etc.)
        }
    }

    void currencyPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
        if (currencyPicker.SelectedIndex != -1)
        {
            selectedCurrency = currencyPicker.SelectedItem.ToString();
            // Do something with the selected country (store it, process it, etc.)
        }
    }

    void genderPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
        if (genderPicker.SelectedIndex != -1)
        {
            selectedGender = genderPicker.SelectedItem.ToString();
            // Do something with the selected country (store it, process it, etc.)
        }
    }

    void entryCheck()
    {
        if ((!string.IsNullOrEmpty(selectedFirstName)) && (!string.IsNullOrEmpty(selectedSurname))
            && (!string.IsNullOrEmpty(selectedCountry)) && (!string.IsNullOrEmpty(selectedCurrency))
            && (!string.IsNullOrEmpty(selectedGender)))
        {
            NextBtn.IsEnabled = true;
        } else {
            NextBtn.IsEnabled = false;
        }

    }
}