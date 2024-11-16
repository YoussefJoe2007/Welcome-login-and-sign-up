using System.Windows;

namespace Welcome_login_and_sign_up
{
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void CheckAnswers_Click(object sender, RoutedEventArgs e)
        {
            int score = 0;

            if (Q1Option1.IsChecked == true && Q1Option2.IsChecked == true && Q1Option3.IsChecked == true && Q1Option4.IsChecked == false)
                score++;

            if (Q2Option1.IsChecked == true && Q2Option2.IsChecked == true && Q2Option3.IsChecked == false && Q2Option4.IsChecked == true)
                score++;

            if (Q3Option2.IsChecked == true)
                score++;

            if (Q4Option2.IsChecked == true)
                score++;

            if (Q5Option1.IsChecked == true && Q5Option2.IsChecked == true && Q5Option3.IsChecked == false && Q5Option4.IsChecked == true)
                score++;

            if (Q6Option2.IsChecked == true)
                score++;

            if (Q7Option1.IsChecked == true)
                score++;

            if (Q8Option1.IsChecked == true)
                score++;

            if (Q9Option1.IsChecked == true)
                score++;

            if (Q10Option1.IsChecked == true)
                score++;

            MessageBox.Show($"You scored {score} out of 10!", "Quiz Result", MessageBoxButton.OK, MessageBoxImage.Information);

            ResultText.Text = $"Your score is {score} out of 10";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logging out...");
            this.Close();
        }

        private void GoToTodoList_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigating to To-Do List...");
            Window5 toDoListWindow = new Window5();
            toDoListWindow.Show();
            
            this.Close();
        }
    }
}
