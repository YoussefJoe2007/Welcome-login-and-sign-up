using System.Windows;

namespace Welcome_login_and_sign_up
{
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow()
        {
            InitializeComponent();
            Window6 signUpWindow = new Window6();
            signUpWindow.Show();
            this.Close();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 signUpWindow = new Window2();
            signUpWindow.Show();
            this.Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 loginWindow = new Window1();
            loginWindow.Show();
            this.Close();
        }
    }
}
