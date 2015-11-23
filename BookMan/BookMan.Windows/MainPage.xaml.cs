using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BookMan {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void entry1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            //this.Frame.Navigate(typeof(PageTest));

            //Para voltar
            //this.Frame.GoBack();
        }

        private void entry3_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            this.Frame.Navigate(typeof(VerReqPage));
        }
    }
}
