using ShellLogin.Views;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
//using ShellLogin.Views;

namespace ShellLogin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("auth/registration", typeof(RegistrationPage));
            Routing.RegisterRoute("auth/login", typeof(LoginPage));

            Routing.RegisterRoute("main/cats", typeof(CatsPage));

            BindingContext = this;
        }

        public ICommand ExecuteLogout => new Command(async () => await GoToAsync("auth/login"));
        public ICommand ExecuteRegistration => new Command(async () => await GoToAsync("auth/registration"));

        public ICommand ExecuteCatShit => new Command( () =>
        {
            Console.WriteLine("What the fuck!");
            GoToAsync("main/cats");
        }
        );

    }
}
