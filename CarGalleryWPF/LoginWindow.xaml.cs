using System.Windows;
using System.Windows.Input;

namespace CarGalleryWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginCheck()
        {
            if (usernameTB.Text == "admin" && passwordPB.Password == "admin")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong input!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                usernameTB.Clear();
                passwordPB.Clear();
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e) => LoginCheck();

        private void ExitButton_Click(object sender, RoutedEventArgs e) => Close();

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();

        private void passwordPB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                LoginCheck();
        }
    }
}
