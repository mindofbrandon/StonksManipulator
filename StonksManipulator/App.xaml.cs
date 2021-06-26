using StonksManipulator.Services;
using StonksManipulator.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StonksManipulator
{
    public partial class App : Application
    {

        public App()    // The start of the whole program(?)
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
