namespace FutbolerosApp

{
    using FutbolerosApp.Helpers;
    using FutbolerosApp.ViewModels;
    using FutbolerosApp.Views;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;
    public class MostrarReservaPageViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }
        public ICommand LogoutCommand { get; set; }
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                SetProperty(ref _message, value);
            }
        }
        public MostrarReservaPageViewModel()
        {
            LogoutCommand = new Command(Logout);
            Message = "Datos de la Reserva";
        }

        private async void Logout()
        {

            Settings.IsLoggedIn = true;
            await 
            Application.Current.MainPage.DisplayAlert(
              "Futboleros Dice...",
              "Señor usuario se está verificando en el sistema la disponibilidad solicitada....Gracias",
              "Aceptar");
            await Navigation.PushAsync(new ConfirmarCanchaPage());
        }
    }
}
