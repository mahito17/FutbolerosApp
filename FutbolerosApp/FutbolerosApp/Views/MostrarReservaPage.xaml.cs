using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FutbolerosApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarReservaPage : ContentPage
    {
        private MostrarReservaPageViewModel viewModel;
        public MostrarReservaPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MostrarReservaPageViewModel();
            viewModel.Navigation = Navigation;
            datePicker.Date = DateTime.Now;
            datePicker.MinimumDate = new DateTime(2018, 7, 24);
            datePicker.MaximumDate = new DateTime(2020, 1, 1);
            
            
            
        }
        
        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
           // DisplayAlert("", e.NewDate.ToString(), "Aceptar");
        }

        
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
