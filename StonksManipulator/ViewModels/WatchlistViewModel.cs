using System;
using System.Net.Http; // get API accessibility
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StonksManipulator.ViewModels
{
    public class WatchlistViewModel : BaseViewModel
    {
        public WatchlistViewModel()
        {
            Title = "Watchlist";

        }

        public void OnAppearing() // if the page appears
        {
            IsBusy = true;
            GetDataAsync(); // jump to function to grab api data
            //SelectedItem = null;
        }

        // attempting to use api key to get data from finnhub.io
        public async Task GetDataAsync()
        {
            HttpClient client = new HttpClient(); // create an instance to send HTTP requests

            string text = await client.GetStringAsync("https://finnhub.io/api/v1/quote?symbol=AAPL&token="); // takes a URI and returns response as string
            // token=APIKEY
            //Console.WriteLine(text);
            System.Diagnostics.Debug.WriteLine(text); // debugging
        }

    }
}