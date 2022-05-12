using Signtitik.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Signtitik.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        ObservableCollection<SignModel> signList;
        public CategoryPage(string category)
        {
            InitializeComponent();
            if (category.Equals("Phrase"))
                category += GlobalData.Identity;
            signList = new ObservableCollection<SignModel>(DataClass.signList.Where(s => s.Category != null && s.Category.Equals(category)).ToList());
            categoryListView.ItemsSource = signList;

            categoryListView.ItemTapped += async (object sender, ItemTappedEventArgs e) =>
            {
                var sign = (SignModel)e.Item;
                SignPage signPage = new SignPage();
                signPage.BindingContext = sign;
                await Navigation.PushModalAsync(signPage);
            };
        }
    }
}