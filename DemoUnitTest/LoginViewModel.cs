using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoUnitTest
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private IAuthService _authService;

        public ICommand LoginCommand { get; }

        public LoginViewModel(IAuthService authService)
        {
            _authService = authService;
            LoginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            IsLoggedIn = _authService.Login(Username, Password);
        }

        private string username;
        private string password;
        private bool isLoggedIn;

        public string Username
        {
            get { return username; }
            set
            {
                if(username != value)
                {
                    username = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Username)));

                }
                username = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(password)));

                }
                password = value;
            }
        }


        public bool IsLoggedIn { 
            get {
                return isLoggedIn;            
            }
            set
            {
                if (isLoggedIn != value)
                {
                    isLoggedIn = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsLoggedIn)));
                }
            }
        }    

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
