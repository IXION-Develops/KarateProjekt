using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Manager_Turnieju.ViewModels
{
    class AuthorizeViewModel : Screen
    {
        private SecureString securyePassword = new SecureString();
        private string pass = "1234";
        private string tempPassword;

        public string Password
        {
            get { return tempPassword; }
            set 
            {
                tempPassword = value;
                NotifyOfPropertyChange(() => Password);
            }
        }
        public void Click()
        {
            SetSecurePassword();
            if (PasswordVerification(Password))
            {
                MessageBox.Show("New page");
                // pass new window
            }
            else
            {
                MessageBox.Show("Nieprawidłowe hasło");
                ClearPassword();
            }
        }

        public bool PasswordVerification(string password)
        {
            if (password == pass)
                return true;
            return false;
        }

        private void ClearPassword()
        {
            Password = null;
        }
        private void SetSecurePassword()
        {
            if (tempPassword != null)
            {
                foreach (char c in tempPassword.ToCharArray())
                {
                    securyePassword.AppendChar(c);
                }
            }
        }
    }
}
