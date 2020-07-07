using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        String[] quotes;
        int index;

        public QuotesPage()
        {
            InitializeComponent();

            quotes = new string[]
                {
                    "Life is like riding a bicycle. To keep your balance, you must keep moving.",
                    "You can't blame gravity for falling in love.",
                    "Look deep into nature, and then you will understand everything better."
                };

            label.Text = quotes[index];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            index++;
            if (index == quotes.Length)
            { index = 0; }
            label.Text = quotes[index];
        }
    }
}