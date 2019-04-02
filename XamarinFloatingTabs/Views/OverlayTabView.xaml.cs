using Xamarin.Forms;

namespace XamarinFloatingTabs.Views
{
    public partial class OverlayTabView : ContentView
    {
        public OverlayTabView()
        {
            InitializeComponent();
            Tab1.TextColor = Color.Gray;
            Tab2.TextColor = Tab3.TextColor = Color.DarkGray;
        }

        private void OnDiscoveryClicked(object sender, System.EventArgs e)
        {
            if (App.Current.MainPage is TabbedPage mainPage && sender is Button button)
            {
                mainPage.CurrentPage = mainPage.Children[0];
                Tab1.TextColor = Color.Gray;
                Tab2.TextColor = Tab3.TextColor = Color.DarkGray;
            }
        }

        private void OnSearchClicked(object sender, System.EventArgs e)
        {
            if (App.Current.MainPage is TabbedPage mainPage && sender is Button button)
            {
                mainPage.CurrentPage = mainPage.Children[1];
                Tab2.TextColor = Color.Gray;
                Tab1.TextColor = Tab3.TextColor = Color.DarkGray;
            }
        }

        private void OnBookmarksClicked(object sender, System.EventArgs e)
        {
            if (App.Current.MainPage is TabbedPage mainPage && sender is Button button)
            {
                mainPage.CurrentPage = mainPage.Children[2];
                Tab3.TextColor = Color.Gray;
                Tab1.TextColor = Tab2.TextColor = Color.DarkGray;
            }
        }
    }
}