using FFImageLoading.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Signtitik.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignPage : ContentPage
    {
        public SignPage()
        {
            InitializeComponent();
		}

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}