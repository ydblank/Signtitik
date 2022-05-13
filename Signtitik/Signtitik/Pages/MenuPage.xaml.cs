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
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void BackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(false);
        }

        private async void ItemTapped(object sender, EventArgs e)
        {
            StackLayout stackLayout = sender as StackLayout;
            CategoryPage categoryPage = new CategoryPage(stackLayout.ClassId);
            await Navigation.PushModalAsync(categoryPage,false);
        }
    }
}