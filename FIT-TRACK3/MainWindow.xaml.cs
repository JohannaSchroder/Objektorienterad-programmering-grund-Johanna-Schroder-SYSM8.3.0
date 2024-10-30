using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FIT_TRACK3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)//Tar en till registreringsidan
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            this.Close();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            var username = UserNameBox.Text;
            var password = PasswordBox.Password;

            if (_userService.LogIn(username, password))
            {
                // Öppna WorkoutsWindow
                var workoutsWindow = new WorkoutsWindow(username);
                workoutsWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord");
            }
        }
    }
}
