using Microsoft.Maui.Controls;

namespace Maui_Page_Navigation
{
    public partial class MessagePage : ContentPage
    {
        public MessagePage(string message)
        {
            InitializeComponent();
            lblMessage.Text = string.IsNullOrWhiteSpace(message) ? "No message received" : message;
        }

        private void OnGoBackClicked(object sender, EventArgs e)
        {
            // Navigate back to the previous page
            Navigation.PopAsync();
        }
    }
}