namespace BM23.Pages;

public partial class Search : ContentPage
{
    string searchString;

    public Search()
	{
		InitializeComponent();
	}

    void Search_Entry_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
		searchString = Search_Entry.Text;
    }
}
