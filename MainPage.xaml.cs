using Microsoft.Maui.Controls;

namespace Maui_Page_Navigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSendMessageClicked(object sender, EventArgs e)
        {
            HandleMessage(txtMessage.Text);
        }

        private async void HandleMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                await DisplayAlert("No Message", "No message received", "OK");
            }
            else
            {
                await Navigation.PushAsync(new MessagePage(message));
            }
        }
    }
}