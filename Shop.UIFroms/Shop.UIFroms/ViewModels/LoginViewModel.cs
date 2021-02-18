using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.UIFroms.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        public LoginViewModel()
        {
            this.Email = "rayct7@gmail.com";
            this.Password = "123456";
        }

        private async void Login()
        {
            if(string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You Most Acces a Email",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You Most Acces a Password",
                    "Accept");
                return;
            }

            if(!this.Email.Equals("rayct76@gmail.com") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert(
                "Error",
                "Login ir Password is wrong!!",
                "Accept");
                return;
            }

            await Application.Current.MainPage.DisplayAlert(
            "Ok",
            "Fuck Yeah!!",
            "Accept");
            return;
        }
    }
}
