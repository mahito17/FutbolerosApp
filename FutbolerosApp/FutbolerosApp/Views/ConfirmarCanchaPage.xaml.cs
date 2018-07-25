namespace FutbolerosApp.Views
{
    using FutbolerosApp.Helpers;
    using FutbolerosApp.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmarCanchaPage : ContentPage
    {
        private ConfirmarCanchaPageViewModel viewModel;
        public ConfirmarCanchaPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ConfirmarCanchaPageViewModel();
            viewModel.Navigation = Navigation;
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}

