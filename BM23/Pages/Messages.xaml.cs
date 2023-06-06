using Microsoft.Maui.Controls;

namespace BM23.Pages;

public partial class Messages : ContentPage
{
	public Messages()
	{
		InitializeComponent();

		List<Inbox> messageTitles = new List<Inbox>()
		{
			new Inbox { Title="Title1", Preview = "Preview1", Mail = "Mail1"},
            new Inbox { Title="Title2", Preview = "Preview2", Mail = "Mail2"},
            new Inbox { Title="Title3", Preview = "Preview3", Mail = "Mail3"},
            new Inbox { Title="Title4", Preview = "Preview4", Mail = "Mail4"},
            new Inbox { Title="Title5", Preview = "Preview5", Mail = "Mail5"},
            new Inbox { Title="Title6", Preview = "Preview6", Mail = "Mail6"},
            new Inbox { Title="Title7", Preview = "Preview7", Mail = "Mail7"},
            new Inbox { Title="Title8", Preview = "Preview8", Mail = "Mail8"},
            new Inbox { Title="Title9", Preview = "Preview9", Mail = "Mail9"},
            new Inbox { Title="Title10", Preview = "Preview10", Mail = "Mail10"},
            new Inbox { Title="Title11", Preview = "Preview11", Mail = "Mail11"},
            new Inbox { Title="Title12", Preview = "Preview12", Mail = "Mail12"},
            new Inbox { Title="Title13", Preview = "Preview13", Mail = "Mail13"},
            new Inbox { Title="Title14", Preview = "Preview14", Mail = "Mail14"},
            new Inbox { Title="Title15", Preview = "Preview15", Mail = "Mail15"},
            new Inbox { Title="Title16", Preview = "Preview16", Mail = "Mail16"},
            new Inbox { Title="Title17", Preview = "Preview17", Mail = "Mail17"},
            new Inbox { Title="Title18", Preview = "Preview18", Mail = "Mail18"},
        };

		listMessageTitles.ItemsSource = messageTitles;
	}

	public class Inbox
	{
		public string Title { get; set; }
        public string Preview { get; set; }
        public string Mail { get; set; }
    }

    private void listMessageTitles_SelectionChanged(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Inbox selectedInbox)
        {
            EmailsLabel.Text = selectedInbox.Mail;
            selectedInbox.Title = "secildim anam";
        }
    }
}
