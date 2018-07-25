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
    public class SeleccionCanchaPageViewModel : ViewModelBase
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
        public SeleccionCanchaPageViewModel()
        {
            LogoutCommand = new Command(Logout);
            Message = "Por favor Seleccione la Cancha";
        }

        private async void Logout()
        {
            Settings.IsLoggedIn = false;
            await Navigation.PushAsync(new MostrarReservaPage());
        }
    }
}
    
