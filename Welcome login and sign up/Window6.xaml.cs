using System.Linq;
using System.Windows;
using System.Windows.Controls; // لضمان استخدام عناصر واجهة المستخدم

namespace Welcome_login_and_sign_up
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        TaskContext taskContext = new TaskContext();

        public Window6()
        {
            InitializeComponent();
            data.ItemsSource = taskContext.Users.ToList();
        }

        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
