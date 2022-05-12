using Signtitik.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Signtitik
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LandingButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            GlobalData.Identity = button.ClassId;
            MenuPage menuPage = new MenuPage();
            await Navigation.PushModalAsync(menuPage);
        }
    }
}
