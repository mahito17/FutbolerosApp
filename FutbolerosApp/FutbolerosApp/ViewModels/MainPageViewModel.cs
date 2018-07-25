// Helpers/Settings.cs
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
    using FutbolerosApp.Models;
    using System.Collections.ObjectModel;

    public class MainPageViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }
        public ICommand LogoutCommand { get; set; }
        private string _message;
        public ListaCanchas LstCanchas { get; set; }
        public ObservableCollection<Cancha> lCanchas;
        public ObservableCollection<Cancha> LCanchas
        {
            get { return lCanchas; }
            set
            {
                if (lCanchas != value)
                {
                    lCanchas = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                SetProperty(ref _message, value);
            }
        }
        public MainPageViewModel()
        {
            LogoutCommand = new Command(Logout);
            Message = "Canchas Registradas";
            LstCanchas = new ListaCanchas();
            LCanchas = LstCanchas.Canchas;
        }

        private async void Logout()
        {
            Settings.IsLoggedIn = false;
            await Navigation.PushAsync(new SeleccionCanchaPage());
        }
    }
}