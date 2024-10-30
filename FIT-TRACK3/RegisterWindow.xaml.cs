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
        private string _usernameinput;
        public string UserNameInput
        {
            get { return _usernameinput; }
            set { _usernameinput = value; OnPropertyChanged(); }
        }
        private string _passwordinput;
        public string PasswordInput
        {
            get { return _passwordinput; }
            set { _passwordinput = value; OnPropertyChanged(); }
        }
        private string _confirmedpassword;
        public string ConfirmedPassword
        {
            get { return _confirmedpassword; }
            set { _confirmedpassword = value; OnPropertyChanged(); }
        }




        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameInput) ||
                string.IsNullOrWhiteSpace(PasswordInput) ||
                string.IsNullOrWhiteSpace(ConfirmedPassword) ||
                string.IsNullOrWhiteSpace(ValtLand))
            {
                MessageBox.Show("Du måste fylla i alla fält!");
                return;
            }
            if (PasswordInput != ConfirmedPassword)
            {
                MessageBox.Show("Dina lösenord matchar inte");
                return;
            }
            try
            {
                userService.RegisterUser(UserNameInput, PasswordInput, ValtLand);
                MessageBox.Show($"Du är registrerad {UserNameInput} och kan logga in!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Application.Current.Windows.OfType<RegisterWindow>().First().Close();
            }
            catch
            {
                MessageBox.Show("Gör ett nytt försök, något gick fel!");
                return;
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
