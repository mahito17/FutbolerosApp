namespace FutbolerosApp.ViewModels
{
    using FutbolerosApp.Helpers;
    using FutbolerosApp.Models;
    using FutbolerosApp.Views;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;
    public class LoginPageViewModel : ViewModelBase
    {
        #region Commands
        public INavigation Navigation { get; set; }
        public ICommand LoginCommand { get; set; }

        #endregion

        #region Propiedades
        private User _user = new User();

        public User User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        #endregion

        public LoginPageViewModel()
        {
            LoginCommand = new Command(Login);
        }
        public async void Login()
        {
            IsBusy = true;
            Title = string.Empty;
            try
            {
                if (User.Email != null)
                {
                    if (User.Password != null)
                    {
                        if (User.Email == "mahito17@hotmail.com" && User.Password == "12345")
                        {
                            Settings.IsLoggedIn = true;
                            await Application.Current.MainPage.DisplayAlert(
                              "Usuario Registrado",
                              "Bienvenido",
                              "Aceptar");
                            await Navigation.PushAsync(new MainPage());

                            this.User.Email = string.Empty;
                            this.User.Password = string.Empty;
                            return;

                        }
                        else
                        {
                            IsBusy = false;
                            await Application.Current.MainPage.DisplayAlert(
                                "Error",
                                "Usuario o Clave Incorrecta",
                                "Aceptar");

                        }

                    }
                    else
                    {
                        IsBusy = false;
                        await Application.Current.MainPage.DisplayAlert(
                                "Error",
                                "La Contraseña esta Errada",
                                "Aceptar");

                    }

                }
                else
                {
                    IsBusy = false;
                    await Application.Current.MainPage.DisplayAlert(
                                 "Error",
                                 "Correo Obligatorio",
                                 "Aceptar");

                }

            }
            catch (Exception e)
            {
                IsBusy = false;
                await App.Current.MainPage.DisplayAlert("Error de conexión", e.Message, "Ok");
            }
        }
    }
}