using StonksManipulator.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StonksManipulator.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}