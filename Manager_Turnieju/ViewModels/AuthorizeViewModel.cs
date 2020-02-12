using Caliburn.Micro;
using System;
using System.Security;
using System.Windows;

namespace Manager_Turnieju.ViewModels
{
    public class AuthorizeViewModel : Screen
    {
    
        
        private SecureString securyePassword = new SecureString();
        private string pass = "1234";
        private string tempPassword;


        private readonly WindowManager _windowManager;
        private readonly ManagerViewModel _managerViewModel;
        public AuthorizeViewModel(WindowManager windowManager, ManagerViewModel managerViewModel)
        {
            _windowManager = windowManager;
            _managerViewModel = managerViewModel;
        }

        public string Password
        {
            get { return tempPassword; }
            set 
            {
                tempPassword = value;
                //CanClick(tempPassword);
                NotifyOfPropertyChange(() => Password);
            }
        }
        public bool CanClick(string tempPassword)
        {
            return !String.IsNullOrWhiteSpace(tempPassword);
        }


        public void Click(string tempPassword)
        {
            SetSecurePassword();
            if (PasswordVerification(Password))
            {
                _windowManager.ShowWindow(_managerViewModel, null, null);
                this.TryClose();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe hasło");
                ClearPassword();
            }
        }

        private void ClearPassword()
        {
            Password = null;
        }


        public bool PasswordVerification(string password)
        {
            if (password == pass)
                return true;
            return false;
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
