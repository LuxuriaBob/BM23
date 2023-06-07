using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using MySql.Data.MySqlClient;
using System.Data;

namespace BM23.Pages;

public partial class Search : ContentPage
{
    string query;
    private const string ConnectionString = "Server=localhost;Database=PracticeDB;Uid=root;Pwd=;";

    public Search()
	{
		InitializeComponent();

        // Create the list view to display the results
        var listView = new ListView();

        // Create a MySQL connection
        using (var connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            // Create a command to execute the query
            var command = new MySqlCommand("SELECT * FROM employee", connection);

            // Execute the query and retrieve the results
            using (var reader = command.ExecuteReader())
            {
                // Create a list to hold the query result
                var results = new List<string>();

                // Loop through the query result and add each row to the list
                while (reader.Read())
                {
                    // Assuming the "employee" table has a "name" column, you can change it accordingly
                    results.Add(reader.GetString("first_name"));
                }

                // Set the list as the data source for the list view
                listView.ItemsSource = results;
            }
        }

        // Add the list view to the page's content
        Content = new Microsoft.Maui.Controls.StackLayout
        {
            Children = { listView }
        };
    }

    void Search_Entry_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
		query = Search_Entry.Text;
    }
}