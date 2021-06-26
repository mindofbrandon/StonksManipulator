using StonksManipulator.Models; // need to include this
using StonksManipulator.ViewModels; // in order to bind the Title in line 20
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StonksManipulator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WatchlistPage : ContentPage
    {
        WatchlistViewModel _viewModel; // create viewmodel object
        public WatchlistPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new WatchlistViewModel(); // to bind items together
        }

        protected override void OnAppearing() // attempting to call function when page opens
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }


    }
}