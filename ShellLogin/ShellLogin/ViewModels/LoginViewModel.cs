using ShellLogin.Services.Routing;
using Splat;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShellLogin.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        private readonly bool isLoginValid = true;
        private IRoutingService _navigationService;

        public LoginViewModel(IRoutingService navigationService = null)
        {
            _navigationService = navigationService ?? Locator.Current.GetService<IRoutingService>();
            ExecuteLogin = new Command(() => Login());
            ExecuteRegistration = new Command(() => Register());
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand ExecuteLogin { get; set; }
        public ICommand ExecuteRegistration { get; set; }

        private void Login()
        {
            // This is where you would probably check the login and only if valid do the navigation...

            if (isLoginValid)
            {
                _navigationService.NavigateTo("///main/home");
                //_navigationService.NavigateTo("///main/cats");
            }
        }

        private void Register()
        {
            Shell.Current.GoToAsync("//login/registration");
        }
    }
}
