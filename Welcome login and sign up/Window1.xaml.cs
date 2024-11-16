using System.Windows;
using static Welcome_login_and_sign_up.Class1;

namespace Welcome_login_and_sign_up
{
    
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (Window2.RegisteredUser == null)
            {
                MessageBox.Show("Please register first.");
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (((User)Window2.RegisteredUser).username!= username || ((User)Window2.RegisteredUser).password!= password)
            {
                MessageBox.Show("Incorrect username or password.");
                return;
            }

            
            MessageBox.Show($"You have successfully logged in.!\nHello، {username}");

            Window4 welcomeWindow = new Window4();
            welcomeWindow.Show();

            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
           WelcomeWindow welcomeWindow = new WelcomeWindow();
            welcomeWindow.Show();
            this.Close();
        }

        private void UsernameTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        }
    }
}
