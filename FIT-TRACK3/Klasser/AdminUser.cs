﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FIT_TRACK3.Klasser
{
    internal class AdminUser : User
    {

        //Konstruktor
        public AdminUser(string UserName, string Password, string Country)
            : base(UserName, Password, Country)
        {
            this.Country = Country;
            this.UserName = UserName;
            this.Password = Password;
        }

        //Metod

        public void MenageAllWorkouts()
        {
            MessageBox.Show("Hej Admin! Här kan du lägga till och ändra träningspass");
        }
    }
}
