using FIT_TRACK3.Klasser;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FIT_TRACK3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        UserService userService;
        public MainWindow()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)//Tar en till registreringsidan
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            this.Close();
        }

        private string _usernamebox;
        public string UserNameBox
        {
            get { return _usernamebox; }
            set { _usernamebox = value; OnPropertyChanged();}
        }
        private string _passwordbox;
        public string PasswordBox
        {
            get { return _passwordbox; }
            set { _passwordbox = value; OnPropertyChanged();}
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)//tar en till WorkoutWindow 
        {
            var username = UserName.Text;
            var password = PassWord.Text;

            if (userService.SignIn(username, password)
            {
                WorkoutWindow workoutWindow = new WorkoutWindow();
                workoutWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord");
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
