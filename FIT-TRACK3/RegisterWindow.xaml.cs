using FIT_TRACK3.Klasser;
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
using System.Windows.Shapes;

namespace FIT_TRACK3
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {

        public RegisterWindow()
        {
            InitializeComponent();
        }
        UserControl userControl = new UserControl();
        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            var username = UserNameInput.Text;
            var password = PasswordInput.Password;
            var country = Land.SelectedItem.ToString();

            if (userControl.RegisterUser(username, password, country))
            {
                MessageBox.Show("Registrering lyckades!");
                // Stäng registreringsfönstret och öppna huvudfönstret
                var mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Användarnamnet är upptaget!");
            }
        }
    }
}
