using FIT_TRACK3.Klasser;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class RegisterWindow : Window, INotifyPropertyChanged
    {
        UserService userService;
        public ObservableCollection<string> Land { get; set; }
        public RegisterWindow()
        {
            InitializeComponent();
            DataContext= this;
            userService = new UserService();
            Land = new ObservableCollection<string> { "Sweden" };
        }

        private string _valtLand;

        public string ValtLand
        {
            get { return _valtLand; }
            set { _valtLand = value; OnPropertyChanged(nameof(ValtLand)); }
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            var username = UserNameinput.Text;
            var password = PasswordInput.Password;

            if (ValtLand.SelectedItem is string country)
            {
                if (userService.RegisterUser(username, password, country))
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
            else
            {
                MessageBox.Show("Vänligen välj ett land.");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
