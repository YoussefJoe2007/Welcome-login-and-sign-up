using System.Windows;

namespace Welcome_login_and_sign_up
{

    public partial class Window3 : Window
    {
        public Window3(string username, string email)
        {
            InitializeComponent();

            UsernameTextBlock.Text = username;
            EmailTextBlock.Text = email;


        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window = new Window1();
            Window.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindow Window = new WelcomeWindow();
            Window.Show();
            this.Close();

        }
    }
}
