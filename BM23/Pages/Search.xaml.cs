using MySql.Data.MySqlClient;
using System.Data;

namespace BM23.Pages;

public partial class Search : ContentPage
{
    string searchString, connectionString, query;

    public Search()
	{
		InitializeComponent();
	}

    void Search_Entry_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
		searchString = Search_Entry.Text;

        /*
        connectionString = "server=<your-server>;user=<your-username>;password=<your-password>;database=<your-database>";
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            // Open the connection
            connection.Open();

            // Execute your queries here
            // ...
            query = "SELECT * FROM your_table";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Access the retrieved data using reader.GetString(), reader.GetInt32(), etc.
                        // ...
                        //reader.GetString();
                    }
                }
            }


        }
        */
    }
}
