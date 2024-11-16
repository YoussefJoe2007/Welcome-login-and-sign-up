using System.Windows;
using System.Windows.Controls;
using static Welcome_login_and_sign_up.Class1;

namespace Welcome_login_and_sign_up
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        internal static object RegisteredUser;

        public Window2()
        {
            InitializeComponent();

            
        }




        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            string confirmPassword = ConfirmPasswordBox.Password;
            string email = EmailTextBox.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
           
            if ( !email.Contains("@gmail.com"))
            {
                MessageBox.Show("Please enter a valid email address ending with @gmail.com");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            RegisteredUser = new User
            {
                username = username,
                password= password,
                
            };

            MessageBox.Show($"Registration has been completed successfully.!\nUsername: {username}\nEmail: {email}");

            Window3 welcomeWindow = new Window3(username,email);
            welcomeWindow.Show();
            this.Close();

        }
      

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindow Window = new WelcomeWindow();
            Window.Show();
            this.Close();
        }

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
