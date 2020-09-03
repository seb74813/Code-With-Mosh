using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using Airbnb.Models;

namespace Airbnb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        ObservableCollection<Search> searches;

        public SearchPage()
        {

            InitializeComponent();

            listView.ItemsSource = GetSearches();
        }

        private IEnumerable<Search> GetSearches(string filter = null)
        {
            searches = new ObservableCollection<Search>
            {
                new Search { Id = 0, Location = "West Hollywood, CA, United States", CheckIn = new DateTime(2020, 9, 1), CheckOut = new DateTime(2020, 11, 1)},
                new Search { Id = 1, Location = "Santa Monica, CA, United States", CheckIn = new DateTime(2020, 9, 1), CheckOut = new DateTime(2020, 11, 1)}
            };

            if (string.IsNullOrEmpty(filter))
            { return searches; }

            return searches.Where<Search>(c => c.Location.StartsWith(filter));
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Search;
            DisplayAlert("Selected", search.Location, "OK");
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;
            searches.Remove(search);
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetSearches();

            listView.EndRefresh();
        }


        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetSearches(e.NewTextValue);
        }
    }
}