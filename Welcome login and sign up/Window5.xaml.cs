using System.Windows;

namespace Welcome_login_and_sign_up
{
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            string task = TaskInput.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                TaskList.Items.Add(task);
                TaskInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.", "Input Required", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem != null)
            {
                TaskList.Items.Remove(TaskList.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "No Task Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void LogOut_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window4 quizWindow = new Window4();
            quizWindow.Show();
            this.Close();
        }

        private void TryDatabase_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Connecting to the database...");
            Window6 quizWindow = new Window6();
            quizWindow.Show();
            this.Close();
        }
    }
}
