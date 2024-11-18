using Desktop_on_all;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktop_on_all
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private TaskContext context = new TaskContext();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;
            string role = check(email, password);
            if (role == "Student")
            {
                MessageBox.Show("Login successful as Student");

            }
            else if (role == "Teacher")
            {
                MessageBox.Show("Login successful as Teacher");

            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }

        }

        string check(string user_username, string user_password)
        {

            var user = context.Users.FirstOrDefault(u => u.Name == user_username && u.Password == user_password);

            return user.Role;
        }
    }
}
