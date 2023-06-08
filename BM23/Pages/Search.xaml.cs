using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using MySql.Data.MySqlClient;
using System.Data;

namespace BM23.Pages;

public partial class Search : ContentPage
{
    string query1;
    string query = "Jim";
    List<string> results = new List<string>();
    List<string> results2 = new List<string>();
    private const string ConnectionString = "Server=localhost;Database=PracticeDB;Uid=root;Pwd=;";

    public Search()
    {
        InitializeComponent();

        // Create the grid to display the results
        //var grid = new Microsoft.Maui.Controls.Grid();

        // Create a MySQL connection
        using (var connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            var command = "SELECT * FROM employee";
            // Create a command to execute the query
            var fullCommand = new MySqlCommand(command, connection);

            // Execute the query and retrieve the results
            using (var reader = fullCommand.ExecuteReader())
            {
                // Loop through the query result and add each row to the list
                while (reader.Read())
                {
                    // Assuming the "employee" table has a "name" column, you can change it accordingly
                    results.Add(reader.GetString("first_name"));
                    
                    // Set the list as the data source for the grid
                    //grid.Children.Add(label1);
                }
            }

            foreach (string result in results)
            {
                label1.Text += result + " ";
            }
        }

        /*
        // Add the list view to the page's content
        Content = new Microsoft.Maui.Controls.AbsoluteLayout
        {
            Children = { grid }
        };
        */
    }

    void FilterElements()
    {
        foreach (string element in results)
        {
            if (element == query1)
            {
                results2.Add(element);
                label2.Text += element + " ";
            }
        }
    }

    void Search_Entry_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
		query1 = Search_Entry.Text;
    }

    void SearchButton_Clicked(System.Object sender, System.EventArgs e)
    {
        FilterElements();
    }
}