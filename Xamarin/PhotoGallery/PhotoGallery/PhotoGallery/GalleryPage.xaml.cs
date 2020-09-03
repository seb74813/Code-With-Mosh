using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoGallery
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryPage : ContentPage
    {
        public int id;
        
        public GalleryPage()
        {
            InitializeComponent();
            id = 1;
            photo.Source = "http://lorempixel.com/1920/1080/city/" + id; 
        }

        private void Left_Button_Clicked(object sender, EventArgs e)
        {
            id--;
            if (id == 0)
            { id = 10; }
            photo.Source = "http://lorempixel.com/1920/1080/city/" + id;
        }

        private void Right_Button_Clicked(object sender, EventArgs e)
        {
            id++;
            if (id == 11)
            { id = 1;  }
            photo.Source = "http://lorempixel.com/1920/1080/city/" + id;
        }
    }
}