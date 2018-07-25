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
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MainPageViewModel();
            viewModel.Navigation = this.Navigation;
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}