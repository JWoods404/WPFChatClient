using System.Windows;


namespace WPFChatClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel ViewModel = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Connect();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SendChatMessage();
        }

        private void DisconnectButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Disconnect();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Register();
        }
    }
}
