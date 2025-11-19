using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a <see cref="Frame">.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            // Get the current view object
            var appView = ApplicationView.GetForCurrentView();

            // Set the custom title
            appView.Title = "My First UWP Application!";
        }

        // Event handler for button click
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HelloTextBlock.Text = "You clicked the button!";
        }
    }
}
