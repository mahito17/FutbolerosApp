namespace FutbolerosApp.ViewModels
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
    public class ConfirmarCanchaPageViewModel: ViewModelBase
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
        public ConfirmarCanchaPageViewModel()
        {
            LogoutCommand = new Command(Logout);
            Message = "Canchas Registradas";
        }

        private async void Logout()
        {
            Settings.IsLoggedIn = true;
            await
            Application.Current.MainPage.DisplayAlert(
              "Fuboleros dice...",
              "La Reserva ha sido efectuada para el dia Miercoles 25 de Agosto a las 8:30 pm. No olvide" +
              " que para efectos de pago se debe cancelar 15 minutos antes de la hora seleccionada.",
              "Aceptar");
            await Navigation.PushAsync(new LoginPage());


        }
    }
}
