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
            MessageBox.Show(Password);
            SetSecurePassword();
            ClearPassword();
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
