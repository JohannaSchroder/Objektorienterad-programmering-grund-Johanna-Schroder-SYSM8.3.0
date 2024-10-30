using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FIT_TRACK3.Klasser
{
     class User : Person
    {
        //egenskaper
        public string Country { get; set; }


        //konstruktor
        public User(string UserName, string Password, string Country) : base(UserName, Password)
        {
            this.Country = Country;
            this.UserName = UserName;
            this.Password = Password;
        }


        //metoder
        public override void SignIn()
        {
            MessageBox.Show($"Hej {UserName}! Nu är det dags att träna.");
        }
    }
}
