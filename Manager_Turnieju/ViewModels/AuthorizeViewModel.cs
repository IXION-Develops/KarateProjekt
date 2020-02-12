using Caliburn.Micro;
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
                NotifyOfPropertyChange(() => Password);
            }
        }
        public void Click()
        {
            SetSecurePassword();
            if (PasswordVerification(Password))
            {
                // pass to new window
                _windowManager.ShowWindow(_managerViewModel, null, null);
                this.TryClose();
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
